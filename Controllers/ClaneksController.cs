using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KlubPrátelTaborovychOhnu.Data;
using KlubPrátelTaborovychOhnu.Models;
using Microsoft.AspNetCore.Authorization;
using KlubPrátelTaborovychOhnu.ViewModels;

//AUTOMATICKY VYGENEROVANÝ CONTROLLER (z větší části)

namespace KlubPrátelTaborovychOhnu.Controllers
{
    public class ClaneksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClaneksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Claneks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clanek.ToListAsync());
        }       

        // GET: Claneks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clanek = await _context.Clanek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clanek == null)
            {
                return NotFound();
            }

            return View(clanek);
        }

        // GET: Claneks/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Claneks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Textik,Nazev")] Clanek clanek)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clanek);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clanek);
        }

        // GET: Claneks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clanek = await _context.Clanek.FindAsync(id);
            if (clanek == null)
            {
                return NotFound();
            }
            return View(clanek);
        }

        // POST: Claneks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Textik,Nazev")] Clanek clanek)
        {
            if (id != clanek.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clanek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClanekExists(clanek.Id))
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
            return View(clanek);
        }

        // GET: Claneks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clanek = await _context.Clanek
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clanek == null)
            {
                return NotFound();
            }

            return View(clanek);
        }

        // POST: Claneks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clanek = await _context.Clanek.FindAsync(id);
            _context.Clanek.Remove(clanek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClanekExists(int id)
        {
            return _context.Clanek.Any(e => e.Id == id);
        }
        //Hledani clanku GET metoda
        public IActionResult Hledani() 
        {
            Hledani h1 = new Hledani();
            return View(h1);
        }
        //Hledani clanku POST metoda
        [HttpPost]
        public IActionResult Hledani(Hledani h) 
        {
            h.PocetClanku = Pocet();
            h.CLanky = _context.Clanek.Where(x => x.Nazev==h.NazevClanku).ToList();
            return View(h);
        }
        //Pocet clanku       
        public int Pocet() 
        {
           return _context.Clanek.ToList().Count;        
        }
    }
}
