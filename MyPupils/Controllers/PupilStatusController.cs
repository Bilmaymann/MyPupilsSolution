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
    public class PupilStatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PupilStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PupilStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.PupilStatuss.ToListAsync());
        }

        // GET: PupilStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pupilStatus = await _context.PupilStatuss
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pupilStatus == null)
            {
                return NotFound();
            }

            return View(pupilStatus);
        }

        // GET: PupilStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PupilStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Sana,Id1,Id2,Id3,Id4,Id5")] PupilStatus pupilStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pupilStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pupilStatus);
        }

        // GET: PupilStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pupilStatus = await _context.PupilStatuss.FindAsync(id);
            if (pupilStatus == null)
            {
                return NotFound();
            }
            return View(pupilStatus);
        }

        // POST: PupilStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Sana,Id1,Id2,Id3,Id4,Id5")] PupilStatus pupilStatus)
        {
            if (id != pupilStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pupilStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PupilStatusExists(pupilStatus.Id))
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
            return View(pupilStatus);
        }

        // GET: PupilStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pupilStatus = await _context.PupilStatuss
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pupilStatus == null)
            {
                return NotFound();
            }

            return View(pupilStatus);
        }

        // POST: PupilStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pupilStatus = await _context.PupilStatuss.FindAsync(id);
            _context.PupilStatuss.Remove(pupilStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PupilStatusExists(int id)
        {
            return _context.PupilStatuss.Any(e => e.Id == id);
        }
    }
}
