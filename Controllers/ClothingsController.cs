﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TjRUsGR6.Data;
using TjRUsGR6.Models;

namespace TjRUsGR6.Controllers
{
    public class ClothingsController : Controller
    {
        private readonly ClothingContext _context;

        public ClothingsController(ClothingContext context)
        {
            _context = context;
        }

        // GET: Clothings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clothings.ToListAsync());
        }

        public async Task<IActionResult> Dame()
        {
            return View();
        }

        public async Task<IActionResult> Herre()
        {
            return View();
        }

        public async Task<IActionResult> Børn()
        {
            return View();
        }

        // GET: Clothings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothing = await _context.Clothings
                .FirstOrDefaultAsync(m => m.ClothingID == id);
            if (clothing == null)
            {
                return NotFound();
            }

            return View(clothing);
        }

        // GET: Clothings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clothings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClothingID,Title,Category,Type,Description,Sizes,Colors,Price,Images")] Clothing clothing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clothing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clothing);
        }

        // GET: Clothings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothing = await _context.Clothings.FindAsync(id);
            if (clothing == null)
            {
                return NotFound();
            }
            return View(clothing);
        }

        // POST: Clothings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClothingID,Title,Category,Type,Description,Sizes,Colors,Price,Images")] Clothing clothing)
        {
            if (id != clothing.ClothingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clothing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClothingExists(clothing.ClothingID))
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
            return View(clothing);
        }

        // GET: Clothings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothing = await _context.Clothings
                .FirstOrDefaultAsync(m => m.ClothingID == id);
            if (clothing == null)
            {
                return NotFound();
            }

            return View(clothing);
        }

        // POST: Clothings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clothing = await _context.Clothings.FindAsync(id);
            _context.Clothings.Remove(clothing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClothingExists(int id)
        {
            return _context.Clothings.Any(e => e.ClothingID == id);
        }
    }
}
