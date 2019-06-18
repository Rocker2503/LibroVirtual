using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibroVirtual.Models;

namespace LibroVirtual.Controllers
{
    public class ApoderadosController : Controller
    {
        private readonly LibroVirtualContext _context;

        public ApoderadosController(LibroVirtualContext context)
        {
            _context = context;
        }

        // GET: Apoderados
        public async Task<IActionResult> Index()
        {
            return View(await _context.Apoderados.ToListAsync());
        }

        // GET: Apoderados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apoderado = await _context.Apoderados
                .FirstOrDefaultAsync(m => m.Id == id);
            if (apoderado == null)
            {
                return NotFound();
            }

            return View(apoderado);
        }

        // GET: Apoderados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Apoderados/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NEPadre,NEMadre,Nombre,Rut,Direccion,Telefono,Email,Emergencia")] Apoderado apoderado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(apoderado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(apoderado);
        }

        // GET: Apoderados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apoderado = await _context.Apoderados.FindAsync(id);
            if (apoderado == null)
            {
                return NotFound();
            }
            return View(apoderado);
        }

        // POST: Apoderados/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NEPadre,NEMadre,Nombre,Rut,Direccion,Telefono,Email,Emergencia")] Apoderado apoderado)
        {
            if (id != apoderado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(apoderado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApoderadoExists(apoderado.Id))
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
            return View(apoderado);
        }

        // GET: Apoderados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apoderado = await _context.Apoderados
                .FirstOrDefaultAsync(m => m.Id == id);
            if (apoderado == null)
            {
                return NotFound();
            }

            return View(apoderado);
        }

        // POST: Apoderados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var apoderado = await _context.Apoderados.FindAsync(id);
            _context.Apoderados.Remove(apoderado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApoderadoExists(int id)
        {
            return _context.Apoderados.Any(e => e.Id == id);
        }
    }
}
