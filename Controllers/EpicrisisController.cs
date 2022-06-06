using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestHistoriasClinicas.Data;
using TestHistoriasClinicas.Models;

namespace TestHistoriasClinicas.Controllers
{
    public class EpicrisisController : Controller
    {
        private readonly TestHistoriasClinicasContext _context;

        public EpicrisisController(TestHistoriasClinicasContext context)
        {
            _context = context;
        }

        // GET: Epicrisis
        public async Task<IActionResult> Index()
        {
            var testHistoriasClinicasContext = _context.Epicrisis.Include(e => e.Diagnostico).Include(e => e.Episodio).Include(e => e.Medico);
            return View(await testHistoriasClinicasContext.ToListAsync());
        }

        // GET: Epicrisis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var epicrisis = await _context.Epicrisis
                .Include(e => e.Diagnostico)
                .Include(e => e.Episodio)
                .Include(e => e.Medico)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (epicrisis == null)
            {
                return NotFound();
            }

            return View(epicrisis);
        }

        // GET: Epicrisis/Create
        public IActionResult Create()
        {
            ViewData["DiagnosticoId"] = new SelectList(_context.Diagnosticos, "Id", "Id");
            ViewData["EpisodioId"] = new SelectList(_context.Episodios, "Id", "Id");
            ViewData["MedicoId"] = new SelectList(_context.Medicos, "Id", "Apellido");
            return View();
        }

        // POST: Epicrisis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EpisodioId,MedicoId,FechaYHora,DiagnosticoId")] Epicrisis epicrisis)
        {
            if (ModelState.IsValid)
            {
                _context.Add(epicrisis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DiagnosticoId"] = new SelectList(_context.Diagnosticos, "Id", "Id", epicrisis.DiagnosticoId);
            ViewData["EpisodioId"] = new SelectList(_context.Episodios, "Id", "Id", epicrisis.EpisodioId);
            ViewData["MedicoId"] = new SelectList(_context.Medicos, "Id", "Apellido", epicrisis.MedicoId);
            return View(epicrisis);
        }

        // GET: Epicrisis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var epicrisis = await _context.Epicrisis.FindAsync(id);
            if (epicrisis == null)
            {
                return NotFound();
            }
            ViewData["DiagnosticoId"] = new SelectList(_context.Diagnosticos, "Id", "Id", epicrisis.DiagnosticoId);
            ViewData["EpisodioId"] = new SelectList(_context.Episodios, "Id", "Id", epicrisis.EpisodioId);
            ViewData["MedicoId"] = new SelectList(_context.Medicos, "Id", "Apellido", epicrisis.MedicoId);
            return View(epicrisis);
        }

        // POST: Epicrisis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EpisodioId,MedicoId,FechaYHora,DiagnosticoId")] Epicrisis epicrisis)
        {
            if (id != epicrisis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(epicrisis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EpicrisisExists(epicrisis.Id))
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
            ViewData["DiagnosticoId"] = new SelectList(_context.Diagnosticos, "Id", "Id", epicrisis.DiagnosticoId);
            ViewData["EpisodioId"] = new SelectList(_context.Episodios, "Id", "Id", epicrisis.EpisodioId);
            ViewData["MedicoId"] = new SelectList(_context.Medicos, "Id", "Apellido", epicrisis.MedicoId);
            return View(epicrisis);
        }

        // GET: Epicrisis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var epicrisis = await _context.Epicrisis
                .Include(e => e.Diagnostico)
                .Include(e => e.Episodio)
                .Include(e => e.Medico)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (epicrisis == null)
            {
                return NotFound();
            }

            return View(epicrisis);
        }

        // POST: Epicrisis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var epicrisis = await _context.Epicrisis.FindAsync(id);
            _context.Epicrisis.Remove(epicrisis);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EpicrisisExists(int id)
        {
            return _context.Epicrisis.Any(e => e.Id == id);
        }
    }
}
