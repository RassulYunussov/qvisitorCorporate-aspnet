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
    public class qvOrderStatusHistoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public qvOrderStatusHistoriesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: qvOrderStatusHistories
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OrderStatusHistories.Include(q => q.NewStatus).Include(q => q.OldStatus).Include(q => q.Orders);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: qvOrderStatusHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvOrderStatusHistory = await _context.OrderStatusHistories.SingleOrDefaultAsync(m => m.Id == id);
            if (qvOrderStatusHistory == null)
            {
                return NotFound();
            }

            return View(qvOrderStatusHistory);
        }

        // GET: qvOrderStatusHistories/Create
        public IActionResult Create()
        {
            ViewData["NewStatusId"] = new SelectList(_context.OrderStatuses, "Id", "NewStatus");
            ViewData["OldStatusId"] = new SelectList(_context.OrderStatuses, "Id", "OldStatus");
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Orders");
            return View();
        }

        // POST: qvOrderStatusHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ActionDate,NewStatusId,OldStatusId,OrderId")] qvOrderStatusHistory qvOrderStatusHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qvOrderStatusHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["NewStatusId"] = new SelectList(_context.OrderStatuses, "Id", "NewStatus", qvOrderStatusHistory.NewStatusId);
            ViewData["OldStatusId"] = new SelectList(_context.OrderStatuses, "Id", "OldStatus", qvOrderStatusHistory.OldStatusId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Orders", qvOrderStatusHistory.OrderId);
            return View(qvOrderStatusHistory);
        }

        // GET: qvOrderStatusHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvOrderStatusHistory = await _context.OrderStatusHistories.SingleOrDefaultAsync(m => m.Id == id);
            if (qvOrderStatusHistory == null)
            {
                return NotFound();
            }
            ViewData["NewStatusId"] = new SelectList(_context.OrderStatuses, "Id", "NewStatus", qvOrderStatusHistory.NewStatusId);
            ViewData["OldStatusId"] = new SelectList(_context.OrderStatuses, "Id", "OldStatus", qvOrderStatusHistory.OldStatusId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Orders", qvOrderStatusHistory.OrderId);
            return View(qvOrderStatusHistory);
        }

        // POST: qvOrderStatusHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ActionDate,NewStatusId,OldStatusId,OrderId")] qvOrderStatusHistory qvOrderStatusHistory)
        {
            if (id != qvOrderStatusHistory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvOrderStatusHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvOrderStatusHistoryExists(qvOrderStatusHistory.Id))
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
            ViewData["NewStatusId"] = new SelectList(_context.OrderStatuses, "Id", "NewStatus", qvOrderStatusHistory.NewStatusId);
            ViewData["OldStatusId"] = new SelectList(_context.OrderStatuses, "Id", "OldStatus", qvOrderStatusHistory.OldStatusId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "Id", "Orders", qvOrderStatusHistory.OrderId);
            return View(qvOrderStatusHistory);
        }

        // GET: qvOrderStatusHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qvOrderStatusHistory = await _context.OrderStatusHistories.SingleOrDefaultAsync(m => m.Id == id);
            if (qvOrderStatusHistory == null)
            {
                return NotFound();
            }

            return View(qvOrderStatusHistory);
        }

        // POST: qvOrderStatusHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qvOrderStatusHistory = await _context.OrderStatusHistories.SingleOrDefaultAsync(m => m.Id == id);
            _context.OrderStatusHistories.Remove(qvOrderStatusHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvOrderStatusHistoryExists(int id)
        {
            return _context.OrderStatusHistories.Any(e => e.Id == id);
        }
    }
}
