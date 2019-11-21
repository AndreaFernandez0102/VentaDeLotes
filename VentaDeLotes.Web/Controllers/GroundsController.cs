using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VentaDeLotes.Web.Data;
using VentaDeLotes.Web.Entities;

namespace VentaDeLotes.Web.Controllers
{
    public class GroundsController : Controller
    {
        private readonly DataContext _context;

        public GroundsController(DataContext context)
        {
            _context = context;
        }

        // GET: Grounds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Grounds.ToListAsync());
        }

        // GET: Grounds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ground = await _context.Grounds
                .FirstOrDefaultAsync(m => m.GroundId == id);
            if (ground == null)
            {
                return NotFound();
            }

            return View(ground);
        }

        // GET: Grounds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Grounds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroundId,Name")] Ground ground)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ground);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ground);
        }

        // GET: Grounds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ground = await _context.Grounds.FindAsync(id);
            if (ground == null)
            {
                return NotFound();
            }
            return View(ground);
        }

        // POST: Grounds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroundId,Name")] Ground ground)
        {
            if (id != ground.GroundId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ground);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroundExists(ground.GroundId))
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
            return View(ground);
        }

        // GET: Grounds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ground = await _context.Grounds
                .FirstOrDefaultAsync(m => m.GroundId == id);
            if (ground == null)
            {
                return NotFound();
            }

            return View(ground);
        }

        // POST: Grounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ground = await _context.Grounds.FindAsync(id);
            _context.Grounds.Remove(ground);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroundExists(int id)
        {
            return _context.Grounds.Any(e => e.GroundId == id);
        }
    }
}
