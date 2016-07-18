using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using qvisitorCorp.Data;

/*
 [Route(“reviews/{reviewId}”)]
    public ActionResult Show(int reviewId) { … }
      */
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
        public async Task<IActionResult> Branches()
        {
            var applicationDbContext = _context.Branches.Include(q => q.City).Include(q => q.Company).Include(q => q.HighBranch);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: qvBranches/Details/5
        [Route("[controller]/branches/[action]/{id}")]
        public async Task<IActionResult> BranchesDetails(int? id)
        {
            /* if (id == null)
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
        [Route("[controller]/branches/[action]/{id}")]
        public async Task<IActionResult> BranchesEdit(int? id)
        {
            /*if (id != qvBranch.Id)
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
            return View(qvBranch);*/
            return View();
        }

        // GET: qvDepartments
        public async Task<IActionResult> Departments()
        {
            var applicationDbContext = _context.Departments.Include(q => q.Branch);
            return View(await applicationDbContext.ToListAsync());
        }
        [Route("/departments/[action]/{id}")]
        // GET: qvDepartments/Details/5
        public async Task<IActionResult> DepartmentsDetails(int? id)
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

            return View(qvDepartment);*/
            return View();
        }
        [Route("/departments/[action]/{id}")]
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
        [Route("admin/company/department/new")]
        public IActionResult CreateObject()
        {
            return View();
        }
        [Route("admin/company/department/show")]
        public IActionResult SelectObject(int departmentId)
        {
            return View();
        }
        [Route("admin/company/department/edit")]
        public IActionResult UpdateObject(int departmentId)
        {
            return View();
        }
        [Route("admin/company")]
        public IActionResult Company()
        {
            return View();
        }
        [Route("admin/company/new")]
        public IActionResult CreateCompany()
        {
            return View();
        }
        [Route("admin/company/show")]
        public IActionResult SelectCompany(int companyId)
        {
            return View();
        }
        [Route("admin/company/edit")]
        public IActionResult UpdateCompany(int companyId)
        {
            return View();
        }
        
        public IActionResult Cabinet()
        {
            return View();
        }
    }
}
