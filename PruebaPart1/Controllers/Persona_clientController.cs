using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaPart1.Data;
using PruebaPart1.Models;

namespace PruebaPart1.Controllers
{
    public class Persona_clientController : Controller
    {
        private readonly AppDBContex _context;

        public Persona_clientController(AppDBContex context)
        {
            _context = context;
        }

        // GET: Persona_client
        public async Task<IActionResult> Index()
        {
              return View(await _context.Persona_cliente.ToListAsync());
        }

        // GET: Persona_client
        public async Task<IActionResult> Interacciones()
        {
            return View(await _context.Persona_cliente.ToListAsync());
        }

        // GET: Persona_client/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Persona_cliente == null)
            {
                return NotFound();
            }

            var persona_client = await _context.Persona_cliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (persona_client == null)
            {
                return NotFound();
            }

            return View(persona_client);
        }

        // GET: Persona_client/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Persona_client/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Documento,primerNombre,segundoNombre,primerApellido,segundoApellido,Telefono,Email,Direccion,Edad,Genero")] Persona_client persona_client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(persona_client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(persona_client);
        }

        // GET: Persona_client/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Persona_cliente == null)
            {
                return NotFound();
            }

            var persona_client = await _context.Persona_cliente.FindAsync(id);
            if (persona_client == null)
            {
                return NotFound();
            }
            return View(persona_client);
        }

        // POST: Persona_client/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Documento,primerNombre,segundoNombre,primerApellido,segundoApellido,Telefono,Email,Direccion,Edad,Genero")] Persona_client persona_client)
        {
            if (id != persona_client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona_client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Persona_clientExists(persona_client.Id))
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
            return View(persona_client);
        }

        // GET: Persona_client/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Persona_cliente == null)
            {
                return NotFound();
            }

            var persona_client = await _context.Persona_cliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (persona_client == null)
            {
                return NotFound();
            }

            return View(persona_client);
        }

        // POST: Persona_client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Persona_cliente == null)
            {
                return Problem("Entity set 'AppDBContex.Persona_cliente'  is null.");
            }
            var persona_client = await _context.Persona_cliente.FindAsync(id);
            if (persona_client != null)
            {
                _context.Persona_cliente.Remove(persona_client);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Persona_clientExists(int id)
        {
          return _context.Persona_cliente.Any(e => e.Id == id);
        }
    }
}
