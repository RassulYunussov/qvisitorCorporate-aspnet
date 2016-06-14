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
    public class qvBranchesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public qvBranchesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: qvBranches
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Branches.Include(q => q.City).Include(q => q.Company).Include(q => q.HighBranch);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: qvBranches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvBranch = await _context.Branches.SingleOrDefaultAsync(m => m.Id == id);
            if (qvBranch == null)
            {
                return NotFound();
            }

            return View(qvBranch);
        }

        // GET: qvBranches/Create
        public IActionResult Create()
        {
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "City");
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Company");
            ViewData["HighBranchId"] = new SelectList(_context.Branches, "Id", "HighBranch");
            return View();
        }

        // POST: qvBranches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CityId,CompanyId,HighBranchId,Name")] qvBranch qvBranch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qvBranch);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "City", qvBranch.CityId);
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Company", qvBranch.CompanyId);
            ViewData["HighBranchId"] = new SelectList(_context.Branches, "Id", "HighBranch", qvBranch.HighBranchId);
            return View(qvBranch);
        }

        // GET: qvBranches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvBranch = await _context.Branches.SingleOrDefaultAsync(m => m.Id == id);
            if (qvBranch == null)
            {
                return NotFound();
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "City", qvBranch.CityId);
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Company", qvBranch.CompanyId);
            ViewData["HighBranchId"] = new SelectList(_context.Branches, "Id", "HighBranch", qvBranch.HighBranchId);
            return View(qvBranch);
        }

        // POST: qvBranches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CityId,CompanyId,HighBranchId,Name")] qvBranch qvBranch)
        {
            if (id != qvBranch.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvBranch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvBranchExists(qvBranch.Id))
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
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "City", qvBranch.CityId);
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Company", qvBranch.CompanyId);
            ViewData["HighBranchId"] = new SelectList(_context.Branches, "Id", "HighBranch", qvBranch.HighBranchId);
            return View(qvBranch);
        }

        // GET: qvBranches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvBranch = await _context.Branches.SingleOrDefaultAsync(m => m.Id == id);
            if (qvBranch == null)
            {
                return NotFound();
            }

            return View(qvBranch);
        }

        // POST: qvBranches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qvBranch = await _context.Branches.SingleOrDefaultAsync(m => m.Id == id);
            _context.Branches.Remove(qvBranch);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvBranchExists(int id)
        {
            return _context.Branches.Any(e => e.Id == id);
        }
    }
}
