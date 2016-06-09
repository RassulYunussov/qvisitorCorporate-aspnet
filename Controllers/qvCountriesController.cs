using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using qvisitorCorp.Data;
using qvisitorCorp.Models;

namespace qvisitorCorporateaspnet.Controllers
{
    public class qvCountriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public qvCountriesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: qvCountries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Countries.ToListAsync());
        }

        // GET: qvCountries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvCountry = await _context.Countries.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCountry == null)
            {
                return NotFound();
            }

            return View(qvCountry);
        }

        // GET: qvCountries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: qvCountries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] qvCountry qvCountry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qvCountry);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(qvCountry);
        }

        // GET: qvCountries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvCountry = await _context.Countries.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCountry == null)
            {
                return NotFound();
            }
            return View(qvCountry);
        }

        // POST: qvCountries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] qvCountry qvCountry)
        {
            if (id != qvCountry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvCountry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvCountryExists(qvCountry.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(qvCountry);
        }

        // GET: qvCountries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvCountry = await _context.Countries.SingleOrDefaultAsync(m => m.Id == id);
            if (qvCountry == null)
            {
                return NotFound();
            }

            return View(qvCountry);
        }

        // POST: qvCountries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qvCountry = await _context.Countries.SingleOrDefaultAsync(m => m.Id == id);
            _context.Countries.Remove(qvCountry);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvCountryExists(int id)
        {
            return _context.Countries.Any(e => e.Id == id);
        }
    }
}
