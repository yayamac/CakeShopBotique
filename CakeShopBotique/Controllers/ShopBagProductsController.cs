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
    public class ShopBagProductsController : Controller
    {
        private readonly CakeShopBotiqueContext _context;

        public ShopBagProductsController(CakeShopBotiqueContext context)
        {
            _context = context;
        }

        // GET: ShopBagProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShopBagProduct.ToListAsync());
        }

        // GET: ShopBagProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopBagProduct = await _context.ShopBagProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopBagProduct == null)
            {
                return NotFound();
            }

            return View(shopBagProduct);
        }

        // GET: ShopBagProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShopBagProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantity,ProductId,ProductName,CustumName,ShopBagId")] ShopBagProduct shopBagProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shopBagProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shopBagProduct);
        }

        // GET: ShopBagProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopBagProduct = await _context.ShopBagProduct.FindAsync(id);
            if (shopBagProduct == null)
            {
                return NotFound();
            }
            return View(shopBagProduct);
        }

        // POST: ShopBagProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Quantity,ProductId,ProductName,CustumName,ShopBagId")] ShopBagProduct shopBagProduct)
        {
            if (id != shopBagProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shopBagProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopBagProductExists(shopBagProduct.Id))
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
            return View(shopBagProduct);
        }

        // GET: ShopBagProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopBagProduct = await _context.ShopBagProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopBagProduct == null)
            {
                return NotFound();
            }

            return View(shopBagProduct);
        }

        // POST: ShopBagProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shopBagProduct = await _context.ShopBagProduct.FindAsync(id);
            _context.ShopBagProduct.Remove(shopBagProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopBagProductExists(int id)
        {
            return _context.ShopBagProduct.Any(e => e.Id == id);
        }
    }
}
