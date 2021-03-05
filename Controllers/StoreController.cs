using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Киберфорум.Models;

namespace Киберфорум.Controllers
{
    public class StoreController : Controller
    {
        private readonly CyberforumContext db;

        public StoreController(CyberforumContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Cart()
        {
            User currentUser = await db.Users.FirstOrDefaultAsync(x => x._Username == User.Identity.Name);
            IQueryable<Order> orders = db.Orders
                .Include(x => x.Stuff)
                .Include(x => x.User).Where(x => x.UserId == currentUser.Id);
            return View(orders);
        }

        // GET: Store
        public async Task<IActionResult> Index(int? stuffs, string name, int page = 1)
        {
            int pageSize = 10;
            //Фильтрация
            IQueryable<Stuff> stuff = db.Stuffs
                .Include(x => x.Orders)
                .Include(x => x.Reviews);
            if (stuffs != null && stuffs != 0)
            {
                stuff = stuff.Where(p => p.Id == stuffs);
            }
            if (!String.IsNullOrEmpty(name))
            {
                stuff = stuff.Where(p => p.Type.Contains(name));
            }
            //Сортировка

            //пагинация
            var count = await stuff.CountAsync();
            var items = await stuff.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            StoreViewModel vm = new StoreViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                StuffFilterViewModel = new StuffFilterViewModel(db.Stuffs.ToList(), stuffs, name),
                Stuffs = stuff
            };
            return View(vm);
        }

        // GET: Store/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stuff = await db.Stuffs
                .Include(x => x.Reviews)
                .ThenInclude(x => x.User)
                .ThenInclude(x => x.Orders)

                .FirstOrDefaultAsync(m => m.Id == id);
            if (stuff == null)
            {
                return NotFound();
            }

            return View(stuff);
        }

        // GET: Store/Create

        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize]
        //public IActionResult Cart()
        //{
        //    return View();
        //}

        // POST: Store/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,_Cost,_Name,Type,Color,Firm,Description,ImageUrl,Size")] Stuff stuff)
        {
            if (ModelState.IsValid)
            {
                db.Add(stuff);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stuff);
        }

        // GET: Store/Edit/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stuff = await db.Stuffs.FindAsync(id);
            if (stuff == null)
            {
                return NotFound();
            }
            return View(stuff);
        }



        [Authorize]
        public async Task<IActionResult> AddToCard(int? id)
        {
            User currentUser = await db.Users.FirstOrDefaultAsync(x => x._Username == User.Identity.Name);
            foreach (Order orders in db.Orders)
            {
                if (orders.UserId == currentUser.Id && orders.StuffId == id)
                {
                    orders._Count++;
                    id = null;
                    db.Orders.Update(orders);
                }

            }
            if (id != null)
            {
                Order order = new Order { StuffId = (int)id, UserId = currentUser.Id, _Count = 1, _Type = 1 };
                db.Orders.Add(order);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // POST: Store/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,_Cost,_Name,Type,Color,Firm,Description,ImageUrl,Size")] Stuff stuff)
        {
            if (id != stuff.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(stuff);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StuffExists(stuff.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(stuff);
        }

        // GET: Store/Delete/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var stuff = await db.Stuffs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stuff == null)
            {
                return NotFound();
            }

            return View(stuff);
        }

        // POST: Store/Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stuff = await db.Stuffs.FindAsync(id);
            foreach (Order o in db.Orders)
            {
                if (o.StuffId == id)
                {
                    db.Remove(o);
                }
            }
            foreach (Review r in db.Reviews)
            {
                if (r.StuffId == id)
                {
                    db.Remove(r);
                }
            }

            db.Stuffs.Remove(stuff);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StuffExists(int id)
        {
            return db.Stuffs.Any(e => e.Id == id);
        }
    }
}
