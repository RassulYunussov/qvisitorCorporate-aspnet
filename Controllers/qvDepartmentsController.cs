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
    public class qvDepartmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public qvDepartmentsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: qvDepartments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Departments.Include(q => q.Branch);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: qvDepartments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvDepartment = await _context.Departments.SingleOrDefaultAsync(m => m.Id == id);
            if (qvDepartment == null)
            {
                return NotFound();
            }

            return View(qvDepartment);
        }

        // GET: qvDepartments/Create
        public IActionResult Create()
        {
            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Branch");
            return View();
        }

        // POST: qvDepartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BranchId,Name")] qvDepartment qvDepartment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qvDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Branch", qvDepartment.BranchId);
            return View(qvDepartment);
        }

        // GET: qvDepartments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvDepartment = await _context.Departments.SingleOrDefaultAsync(m => m.Id == id);
            if (qvDepartment == null)
            {
                return NotFound();
            }
            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Branch", qvDepartment.BranchId);
            return View(qvDepartment);
        }

        // POST: qvDepartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BranchId,Name")] qvDepartment qvDepartment)
        {
            if (id != qvDepartment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvDepartment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvDepartmentExists(qvDepartment.Id))
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
            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Branch", qvDepartment.BranchId);
            return View(qvDepartment);
        }

        // GET: qvDepartments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvDepartment = await _context.Departments.SingleOrDefaultAsync(m => m.Id == id);
            if (qvDepartment == null)
            {
                return NotFound();
            }

            return View(qvDepartment);
        }

        // POST: qvDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qvDepartment = await _context.Departments.SingleOrDefaultAsync(m => m.Id == id);
            _context.Departments.Remove(qvDepartment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvDepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.Id == id);
        }
    }
}
