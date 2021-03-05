using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Киберфорум.Models;

namespace Киберфорум.Controllers
{
    public class AccountController : Controller
    {
        private readonly CyberforumContext _db;
        public AccountController(CyberforumContext context)
        {
            _db = context;
        }
        [Authorize]
        public async Task<IActionResult> Details(string id)
        {
            User CurrentUser = await _db.Users
                .Include(a => a.Articles)
                .Include(r => r.Role)
                .Include(review => review.Reviews).ThenInclude(stuff => stuff.Stuff)
                .Include(c => c.Comments).ThenInclude(c => c.Article)
                .FirstOrDefaultAsync(u => u._Username == id);
            return View(CurrentUser);
        }

        [Authorize]
        public async Task<IActionResult> Update(int? id, int? count)
        {
            User currentUser = await _db.Users.FirstOrDefaultAsync(x => x._Username == User.Identity.Name);
            foreach (Order orders in _db.Orders)
            {
                if (orders.Id == id)
                {
                    if(count>0)
                    {
                        orders._Count = (int)count;
                        _db.Orders.Update(orders);
                    }
                }

            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Cart","Store");
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                bool flag1 = false;
                bool flag2 = false;
                User user = await _db.Users.FirstOrDefaultAsync(u => u._Name == model.Name);
                if (user == null)
                {
                    flag1 = true;
                }
                else
                    ModelState.AddModelError("", "Имя пользователя уже занято. Введите другое имя");
                user = await _db.Users.FirstOrDefaultAsync(u => u._Username == model.Email);
                if (user == null)
                {
                    flag2 = true;
                }
                else { ModelState.AddModelError("", "Данный логин уже занят. Введите другой"); }
                if(flag1 && flag2)
                {
                    // добавляем пользователя в бд
                    user = new User { _Username = model.Email, _Password = model.Password, _Name = model.Name };
                    Role userRole = await _db.Roles.FirstOrDefaultAsync(r => r.Name == "user");
                    if (userRole != null)
                        user.Role = userRole;

                    _db.Users.Add(user);
                    await _db.SaveChangesAsync();

                    await Authenticate(user); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateComment(string commentText, int articleId)
        {
            User user = _db.Users.FirstOrDefault(u => u._Username == User.Identity.Name);
            Comment comment = new Comment { _Text = commentText, UserId = user.Id, ArticleId = articleId};
            _db.Comments.Add(comment);
            await _db.SaveChangesAsync();
            return RedirectToAction("Details", "Home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = await _db.Orders
                .FirstOrDefaultAsync(m => m.Id == id);
            _db.Orders.Remove(order);
            _db.SaveChanges();
            return RedirectToAction("Cart","Store");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _db.Users
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u._Username == model.Email && u._Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
        private async Task Authenticate(User user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user._Username),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.Name)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
