#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPupils.Data;
using MyPupils.Models;

namespace MyPupils.Controllers
{
    public class TolovlarController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TolovlarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tolovlar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tolovlar.ToListAsync());
        }

        // GET: Tolovlar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tolovlar = await _context.Tolovlar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tolovlar == null)
            {
                return NotFound();
            }

            return View(tolovlar);
        }

        // GET: Tolovlar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tolovlar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Sana,Id1,Id2,Id3,Id4,Id5")] Tolovlar tolovlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tolovlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tolovlar);
        }

        // GET: Tolovlar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tolovlar = await _context.Tolovlar.FindAsync(id);
            if (tolovlar == null)
            {
                return NotFound();
            }
            return View(tolovlar);
        }

        // POST: Tolovlar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Sana,Id1,Id2,Id3,Id4,Id5")] Tolovlar tolovlar)
        {
            if (id != tolovlar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tolovlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TolovlarExists(tolovlar.Id))
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
            return View(tolovlar);
        }

        // GET: Tolovlar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tolovlar = await _context.Tolovlar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tolovlar == null)
            {
                return NotFound();
            }

            return View(tolovlar);
        }

        // POST: Tolovlar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tolovlar = await _context.Tolovlar.FindAsync(id);
            _context.Tolovlar.Remove(tolovlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TolovlarExists(int id)
        {
            return _context.Tolovlar.Any(e => e.Id == id);
        }
    }
}
