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

namespace KlubPrátelTaborovychOhnu.Controllers
{
    public class OsobaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OsobaController(ApplicationDbContext context)
        {
            _context = context;
        }
        //GET Osoba
        public IActionResult Index()
        {
            return View( _context.Osoba.ToList());
        }
        /*public async Task<IActionResult> Index()
        {
            return View(await _context.Osoba.ToListAsync());
        }*/
        
        //GET Details
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var osoba =  _context.Osoba.FirstOrDefault(x => x.Id == id);
            if (osoba == null)
            {
                return NotFound();
            }
            return View(osoba);
        }
        //GET Create 
        [Authorize]        
        public IActionResult Create()
        {
            return View();
        }
        //POST create
        [HttpPost]        
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Jmeno,Vek")] Osoba osoba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(osoba);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(osoba);
        }
        //GET Edit
        public IActionResult edit(int? id) 
        {
            if (id == null) 
            {
                return NotFound();
            }
            var osoba = _context.Osoba.Find(id);
            if (osoba == null) 
            {
                return NotFound();
            }
            return View(osoba);
        }
        private bool OsobaExists(int id)
        {
            return _context.Osoba.Any(y => y.Id == id);
        }
        //POST Edit
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult edit(int id, [Bind("Id,Jmeno,Vek")] Osoba osoba) 
        {
            if (id != osoba.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid) 
            {
                try
                {
                    _context.Update(osoba);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OsobaExists(osoba.Id))
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
            return View(osoba);
        }
        
    }
}
