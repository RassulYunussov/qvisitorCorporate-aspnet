using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using qvisitorCorp.Data;
using qvisitorCorp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace qvisitorCorp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: qvBranches
        [Route("admin/company/")]
        public async Task<IActionResult> Branches()
        {
            var applicationDbContext = _context.Branches.Include(q => q.City).Include(q => q.Company).Include(q => q.HighBranch);
            return View(await applicationDbContext.ToListAsync());
        }
        [Route("admin/company/branches/show/{id}")]
        // GET: qvBranches/Details/5
        public async Task<IActionResult> BranchesDetails(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvBranch = await _context.Branches.SingleOrDefaultAsync(m => m.Id == id);
            if (qvBranch == null)
            {
                return NotFound();
            }

            return View(qvBranch);*/
            return View();
        }
        [Route("admin/company/branches/create")]
        // GET: qvBranches/Create
        public IActionResult BranchesCreate()
        {
            /*
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "City");
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "Company");
            ViewData["HighBranchId"] = new SelectList(_context.Branches, "Id", "HighBranch");*/
            return View();
        }

        // POST: qvBranches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/company/branches/create")]
        public async Task<IActionResult> BranchesCreate([Bind("Id,CityId,CompanyId,HighBranchId,Name")] qvBranch qvBranch)
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
        }*/
        [Route("admin/company/branches/edit/{id}")]
        // GET: qvBranches/Edit/5
        public async Task<IActionResult> BranchesEdit(int? id)
        {
            /*if (id == null)
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
            return View(qvBranch);*/
            return View();
        }

        // POST: qvBranches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/company/branches/edit/{id}")]
        public async Task<IActionResult> BranchesEdit(int id, [Bind("Id,CityId,CompanyId,HighBranchId,Name")] qvBranch qvBranch)
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
        }*/

        // GET: qvBranches/Delete/5
        [Route("admin/company/branches/delete/{id}")]
        public async Task<IActionResult> BranchesDelete(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvBranch = await _context.Branches.SingleOrDefaultAsync(m => m.Id == id);
            if (qvBranch == null)
            {
                return NotFound();
            }

            return View(qvBranch);*/
            return View();
        }

        // POST: qvBranches/Delete/5
        /*[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("admin/company/branches/delete/{id}")]
        public async Task<IActionResult> BranchesDeleteConfirmed(int id)
        {
            var qvBranch = await _context.Branches.SingleOrDefaultAsync(m => m.Id == id);
            _context.Branches.Remove(qvBranch);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        */
        private bool qvBranchExists(int id)
        {
            return _context.Branches.Any(e => e.Id == id);
        }


        [Route("admin/company/branches/departments")]
        // GET: qvDepartments
        public async Task<IActionResult> Departments()
        {
            var applicationDbContext = _context.Departments.Include(q => q.Branch);
            return View(await applicationDbContext.ToListAsync());
        }

        [Route("admin/company/branches/departments/show/{id}")]
        // GET: qvDepartments/Details/5

        public async Task<IActionResult> DepartmentsDetails(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }
            */
            var qvDepartment = await _context.Departments.SingleOrDefaultAsync(m => m.Id == id);
            /*if (qvDepartment == null)
            {
                return NotFound();
            }*/

            return View(qvDepartment);
        }


        [Route("admin/company/branches/departments/create")]
        // GET: qvDepartments/Create
        public IActionResult DepartmentsCreate()
        {
            //ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Branch");
            return View();
        }

        // POST: qvDepartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/company/branches/departments/create")]
        public async Task<IActionResult> DepartmentsCreate([Bind("Id,BranchId,Name")] qvDepartment qvDepartment)
        {
            /*if (ModelState.IsValid)
            {
                _context.Add(qvDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Branch", qvDepartment.BranchId);
            return View(qvDepartment);
        }
        [Route("admin/company/branches/departments/edit/{id}")]
        // GET: qvDepartments/Edit/5
        public async Task<IActionResult> DepartmentsEdit(int? id)
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
            return View(qvDepartment);*/
            return View();
        }

        [Route("admin/company/branches/departments/edit/{id}")]
        public async Task<IActionResult> DepartmentsEdit(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvDepartment = await _context.Departments.SingleOrDefaultAsync(m => m.Id == id);
            if (qvDepartment == null)
            {
                return NotFound();
            }
            ViewData["BranchId"] = new SelectList(_context.Branches, "Id", "Branch", qvDepartment.BranchId);
            return View(qvDepartment);*/
            return View();
        }

        // POST: qvDepartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("admin/company/branches/departments/edit/{id}")]
        public async Task<IActionResult> DepartmentsEdit(int id, [Bind("Id,BranchId,Name")] qvDepartment qvDepartment)
        {
            /*if (id != qvDepartment.Id)
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
            return View(qvDepartment);*/
            return View();
        }
        [Route("admin/company/branches/departments/delete/{id}")]
        // GET: qvDepartments/Delete/5
        public async Task<IActionResult> DepartmentsDelete(int? id)
        {
            /* if (id == null)
             {
                 return NotFound();
             }

             var qvDepartment = await _context.Departments.SingleOrDefaultAsync(m => m.Id == id);
             if (qvDepartment == null)
             {
                 return NotFound();
             }

             return View(qvDepartment);*/
            return View();
        }
        [Route("admin/company/branches/departments/delete/{id}")]
        // POST: qvDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DepartmentsDeleteConfirmed(int id)
        {
            /* var qvDepartment = await _context.Departments.SingleOrDefaultAsync(m => m.Id == id);
             _context.Departments.Remove(qvDepartment);
             await _context.SaveChangesAsync();
             return RedirectToAction("Index");*/
            return View();
        }

        private bool qvDepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.Id == id);
        }
















        [Route("admin/company/department/show/new")]
        public IActionResult AddUser(int departmentId)
        {
            return View();
        }
        [Route("admin/company/department/show/edit")]
        public IActionResult UpdateUser(int departmentId)
        {
            return View();
        }
        
        [Route("admin/company/department/show")]
        public IActionResult Users(int departmentId)
        {
            return View();
        }
        public IActionResult Cabinet()
        {
            return View();
        }
    }
}
