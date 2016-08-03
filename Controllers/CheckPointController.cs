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
    public class CheckPointController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CheckPointController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: qvEntrances
        [Route("checkpoint/entrances")]
        public async Task<IActionResult> Entrances()
        {
            var applicationDbContext = _context.Entrances.Include(q => q.CheckPoint).Include(q => q.EntranceType).Include(q => q.Order).Include(q => q.Visitor);
            return View(await applicationDbContext.ToListAsync());
        }
        [Route("checkpoint/entrances/show/{id}")]
        // GET: qvEntrances/Details/5
        public async Task<IActionResult> EntrancesDetails(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvEntrance = await _context.Entrances.SingleOrDefaultAsync(m => m.Id == id);
            if (qvEntrance == null)
            {
                return NotFound();
            }

            return View(qvEntrance);*/
            return View();
        }
        [Route("checkpoint/entrances/create/{id}")]
        public IActionResult EntrancesCreate()
        {
            ViewData["CheckPointId"] = new SelectList(_context.CheckPoints, "Id", "CheckPoint");
            ViewData["EntranceTypeId"] = new SelectList(_context.EntranceTypes, "Id", "EntranceType");
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Order");
            ViewData["VisitorId"] = new SelectList(_context.Visitors, "Id", "Visitor");
            return View();
        }

        // POST: qvEntrances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EntrancesCreate([Bind("Id,ActionDate,CheckPointId,EntranceTypeId,OrderId,VisitorId")] qvEntrance qvEntrance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qvEntrance);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["CheckPointId"] = new SelectList(_context.CheckPoints, "Id", "CheckPoint", qvEntrance.CheckPointId);
            ViewData["EntranceTypeId"] = new SelectList(_context.EntranceTypes, "Id", "EntranceType", qvEntrance.EntranceTypeId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Order", qvEntrance.OrderId);
            ViewData["VisitorId"] = new SelectList(_context.Visitors, "Id", "Visitor", qvEntrance.VisitorId);
            return View(qvEntrance);
        }

        [Route("checkpoint/entrances/edit/{id}")]
        public async Task<IActionResult> EntrancesEdit(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvEntrance = await _context.Entrances.SingleOrDefaultAsync(m => m.Id == id);
            if (qvEntrance == null)
            {
                return NotFound();
            }
            ViewData["CheckPointId"] = new SelectList(_context.CheckPoints, "Id", "CheckPoint", qvEntrance.CheckPointId);
            ViewData["EntranceTypeId"] = new SelectList(_context.EntranceTypes, "Id", "EntranceType", qvEntrance.EntranceTypeId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Order", qvEntrance.OrderId);
            ViewData["VisitorId"] = new SelectList(_context.Visitors, "Id", "Visitor", qvEntrance.VisitorId);
            return View(qvEntrance);*/
            return View();
        }
        [Route("checkpoint/entrances/edit/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EntrancesEdit(int id, [Bind("Id,ActionDate,CheckPointId,EntranceTypeId,OrderId,VisitorId")] qvEntrance qvEntrance)
        {
            if (id != qvEntrance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvEntrance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvEntranceExists(qvEntrance.Id))
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
            ViewData["CheckPointId"] = new SelectList(_context.CheckPoints, "Id", "CheckPoint", qvEntrance.CheckPointId);
            ViewData["EntranceTypeId"] = new SelectList(_context.EntranceTypes, "Id", "EntranceType", qvEntrance.EntranceTypeId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Order", qvEntrance.OrderId);
            ViewData["VisitorId"] = new SelectList(_context.Visitors, "Id", "Visitor", qvEntrance.VisitorId);
            return View(qvEntrance);
        }
        [Route("checkpoint/entrances/delete/{id}")]
        // GET: qvEntrances/Delete/5
        public async Task<IActionResult> EntrancesDelete(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvEntrance = await _context.Entrances.SingleOrDefaultAsync(m => m.Id == id);
            if (qvEntrance == null)
            {
                return NotFound();
            }

            return View(qvEntrance);*/
            return View();

        }
        [Route("checkpoint/entrances/delete/{id}")]
        // POST: qvEntrances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EntrancesDeleteConfirmed(int id)
        {
            var qvEntrance = await _context.Entrances.SingleOrDefaultAsync(m => m.Id == id);
            _context.Entrances.Remove(qvEntrance);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvEntranceExists(int id)
        {
            return _context.Entrances.Any(e => e.Id == id);
        }



        [Route("checkpoint/hotentrances")]
        // GET: qvHotEntrances
        public async Task<IActionResult> HotEntrances()
        {
            var applicationDbContext = _context.HotEntrances.Include(q => q.Department);
            return View(await applicationDbContext.ToListAsync());
        }
        [Route("checkpoint/hotentrances/show/{id}")]
        // GET: qvHotEntrances/Details/5
        public async Task<IActionResult> HotEntrancesDetails(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvHotEntrance = await _context.HotEntrances.SingleOrDefaultAsync(m => m.Id == id);
            if (qvHotEntrance == null)
            {
                return NotFound();
            }

            return View(qvHotEntrance);*/
            return View();
        }
        [Route("checkpoint/hotentrances/create")]
        public IActionResult HotEntrancesCreate()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Department");
            return View();
        }

        // POST: qvHotEntrances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("checkpoint/hotentrances/create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HotEntrancesCreate([Bind("Id,Attendant,Comment,DepartmentId,DocumentNumber,Name,Organization,Patronymic,Surname")] qvHotEntrance qvHotEntrance)
        {
            /*if (ModelState.IsValid)
            {
                _context.Add(qvHotEntrance);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Department", qvHotEntrance.DepartmentId);
            return View(qvHotEntrance);*/
            return View();
        }

        [Route("checkpoint/hotentrances/edit/{id}")]
        public async Task<IActionResult> HotEntrancesEdit(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvHotEntrance = await _context.HotEntrances.SingleOrDefaultAsync(m => m.Id == id);
            if (qvHotEntrance == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Department", qvHotEntrance.DepartmentId);
            return View(qvHotEntrance);*/
            return View();
        }
        [Route("checkpoint/hotentrances/edit/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HotEntrancesEdit(int id, [Bind("Id,Attendant,Comment,DepartmentId,DocumentNumber,Name,Organization,Patronymic,Surname")] qvHotEntrance qvHotEntrance)
        {
            if (id != qvHotEntrance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvHotEntrance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvHotEntranceExists(qvHotEntrance.Id))
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
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Department", qvHotEntrance.DepartmentId);
            return View(qvHotEntrance);
        }
        [Route("checkpoint/hotentrances/delete/{id}")]
        // GET: qvHotEntrances/Delete/5
        public async Task<IActionResult> HotEntrancesDelete(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvHotEntrance = await _context.HotEntrances.SingleOrDefaultAsync(m => m.Id == id);
            if (qvHotEntrance == null)
            {
                return NotFound();
            }

            return View(qvHotEntrance);*/
            return View();
        }

        [Route("checkpoint/hotentrances/delete/{id}")]
        // POST: qvHotEntrances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HotEntrancesDeleteConfirmed(int id)
        {
            var qvHotEntrance = await _context.HotEntrances.SingleOrDefaultAsync(m => m.Id == id);
            _context.HotEntrances.Remove(qvHotEntrance);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvHotEntranceExists(int id)
        {
            return _context.HotEntrances.Any(e => e.Id == id);
        }
        public IActionResult Cabinet()
        {
            return View();
        }
    }
}
