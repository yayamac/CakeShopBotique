using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CakeShopBotique.Data;
using CakeShopBotique.Models;

namespace CakeShopBotique.Controllers
{
    public class ShopBagsController : Controller
    {
        private readonly CakeShopBotiqueContext _context;

        public ShopBagsController(CakeShopBotiqueContext context)
        {
            _context = context;
        }

        // GET: ShopBags
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShopBag.ToListAsync());
        }

        // GET: ShopBags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopBag = await _context.ShopBag
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopBag == null)
            {
                return NotFound();
            }

            return View(shopBag);
        }

        // GET: ShopBags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShopBags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CostumerId,TotalPrice,LastUpdate")] ShopBag shopBag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shopBag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shopBag);
        }

        // GET: ShopBags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopBag = await _context.ShopBag.FindAsync(id);
            if (shopBag == null)
            {
                return NotFound();
            }
            return View(shopBag);
        }

        // POST: ShopBags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CostumerId,TotalPrice,LastUpdate")] ShopBag shopBag)
        {
            if (id != shopBag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shopBag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopBagExists(shopBag.Id))
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
            return View(shopBag);
        }

        // GET: ShopBags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopBag = await _context.ShopBag
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopBag == null)
            {
                return NotFound();
            }

            return View(shopBag);
        }

        // POST: ShopBags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shopBag = await _context.ShopBag.FindAsync(id);
            _context.ShopBag.Remove(shopBag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopBagExists(int id)
        {
            return _context.ShopBag.Any(e => e.Id == id);
        }
    }
}
