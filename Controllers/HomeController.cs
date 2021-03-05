using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Киберфорум.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace Киберфорум.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CyberforumContext db;
        readonly IWebHostEnvironment _appEnvironment;
        public HomeController(ILogger<HomeController> logger, CyberforumContext context, IWebHostEnvironment appEnvironment)
        {
            _logger = logger;
            db = context;
            _appEnvironment = appEnvironment;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 15;
            IQueryable<Article> articles = db.Articles.Include(x => x.User).Include(x => x.Comments);
            articles = articles.OrderByDescending(x => x.Id);
            var count = await articles.CountAsync();
            var items = await articles.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            IndexViewModel viewModel = new IndexViewModel { PageViewModel = new PageViewModel(count, page, pageSize), Articles = items };
            //return View(await articles.AsNoTracking().ToListAsync());
            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateCom(string com, int id)
        {
            User currentUser = await db.Users.FirstOrDefaultAsync(x => x._Username == User.Identity.Name);
            Comment comment = new Comment { _Text=com,UserId=currentUser.Id, ArticleId = id};
            db.Comments.Add(comment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Article article = await db.Articles
                    .Include(p => p.User)
                    .Include(p => p.Comments)
                    .ThenInclude(x => x.User)
                    .FirstOrDefaultAsync(p => p.Id == id);
                if (article != null)
                {
                    return View(article);  
                }
            }
            return NotFound();
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(Article article)
        {
            User CurrentUser = await db.Users.FirstOrDefaultAsync(x => x._Username == User.Identity.Name);
            article.UserId = CurrentUser.Id;
            db.Articles.Add(article);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "admin")]
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var article = await db.Articles
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (article == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(article);
        //}
        public IActionResult Delete (int id)
        {
            Article article = db.Articles.Include(x=>x.Comments)
                .FirstOrDefault(x=>x.Id == id);
            foreach (Comment comment in db.Comments)
            {
                if(comment.ArticleId == id)
                {
                    db.Remove(comment);
                }
            }
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Store/Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await db.Articles.FindAsync(id);
            db.Articles.Remove(article);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
