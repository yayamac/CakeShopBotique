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
    public class SildeBannersController : Controller
    {
        private readonly CakeShopBotiqueContext _context;

        public SildeBannersController(CakeShopBotiqueContext context)
        {
            _context = context;
        }

        // GET: SildeBanners
        public async Task<IActionResult> Index()
        {
            return View(await _context.SildeBanner.ToListAsync());
        }

        // GET: SildeBanners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sildeBanner = await _context.SildeBanner
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sildeBanner == null)
            {
                return NotFound();
            }

            return View(sildeBanner);
        }

        // GET: SildeBanners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SildeBanners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image")] SildeBanner sildeBanner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sildeBanner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sildeBanner);
        }

        // GET: SildeBanners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sildeBanner = await _context.SildeBanner.FindAsync(id);
            if (sildeBanner == null)
            {
                return NotFound();
            }
            return View(sildeBanner);
        }

        // POST: SildeBanners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Image")] SildeBanner sildeBanner)
        {
            if (id != sildeBanner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sildeBanner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SildeBannerExists(sildeBanner.Id))
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
            return View(sildeBanner);
        }

        // GET: SildeBanners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sildeBanner = await _context.SildeBanner
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sildeBanner == null)
            {
                return NotFound();
            }

            return View(sildeBanner);
        }

        // POST: SildeBanners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sildeBanner = await _context.SildeBanner.FindAsync(id);
            _context.SildeBanner.Remove(sildeBanner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SildeBannerExists(int id)
        {
            return _context.SildeBanner.Any(e => e.Id == id);
        }
    }
}
