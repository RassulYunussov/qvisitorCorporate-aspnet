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
    public class CabinetController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CabinetController(ApplicationDbContext context)
        {
            _context = context;    
        }

        [Route("cabinet/orders")]
        // GET: ListOfOrders
        public async Task<IActionResult> Orders()
        {
            var applicationDbContext = _context.Orders.Include(q => q.OrderStatus).Include(q => q.OrderType);
            return View(await applicationDbContext.ToListAsync());
        }

         // GET: qvOrders/Details/5
        [Route("cabinet/orders/show/{id}")]
        public async Task<IActionResult> OrdersDetails(int? id)
        {
            /*
            if (id == null)
            {
                return NotFound();
            }

            var qvOrder = await _context.Orders.SingleOrDefaultAsync(m => m.Id == id);
            if (qvOrder == null)
            {
                return NotFound();
            }

            return View(qvOrder);
            */
            return View();
        }
        [Route("cabinet/orders/create")]
        // GET: qvOrders/Create
        public IActionResult OrdersCreate()
        {
            ViewData["OrderStausid"] = new SelectList(_context.OrderStatuses, "Id", "OrderStatus");
            ViewData["OrderTypeid"] = new SelectList(_context.OrderTypes, "Id", "OrderType");
            return View();
        }

        // POST: qvOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("cabinet/orders/create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> OrdersCreate([Bind("Id,CloseTime,EndDate,OpenTime,OrderStausid,OrderTypeid,StartDate")] qvOrder qvOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qvOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["OrderStausid"] = new SelectList(_context.OrderStatuses, "Id", "OrderStatus", qvOrder.OrderStausid);
            ViewData["OrderTypeid"] = new SelectList(_context.OrderTypes, "Id", "OrderType", qvOrder.OrderTypeid);
            return View(qvOrder);
        }

        [Route("cabinet/orders/edit/{id}")]
        public async Task<IActionResult> OrdersEdit(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvOrder = await _context.Orders.SingleOrDefaultAsync(m => m.Id == id);
            if (qvOrder == null)
            {
                return NotFound();
            }
            ViewData["OrderStausid"] = new SelectList(_context.OrderStatuses, "Id", "OrderStatus", qvOrder.OrderStausid);
            ViewData["OrderTypeid"] = new SelectList(_context.OrderTypes, "Id", "OrderType", qvOrder.OrderTypeid);
            return View(qvOrder);*/
            return View();
        }

        // POST: qvOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("cabinet/orders/edit/{id}")]
        public async Task<IActionResult> OrdersEdit(int id, [Bind("Id,CloseTime,EndDate,OpenTime,OrderStausid,OrderTypeid,StartDate")] qvOrder qvOrder)
        {
            if (id != qvOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qvOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!qvOrderExists(qvOrder.Id))
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
            ViewData["OrderStausid"] = new SelectList(_context.OrderStatuses, "Id", "OrderStatus", qvOrder.OrderStausid);
            ViewData["OrderTypeid"] = new SelectList(_context.OrderTypes, "Id", "OrderType", qvOrder.OrderTypeid);
            return View(qvOrder);
        }
        [Route("cabinet/orders/delete/{id}")]
        // GET: qvOrders/Delete/5
        public async Task<IActionResult> OrdersDelete(int? id)
        {
            /*if (id == null)
            {
                return NotFound();
            }

            var qvOrder = await _context.Orders.SingleOrDefaultAsync(m => m.Id == id);
            if (qvOrder == null)
            {
                return NotFound();
            }

            return View(qvOrder);*/
            return View();
        }

        // POST: qvOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("cabinet/orders/delete/{id}")]
        public async Task<IActionResult> OrdersDeleteConfirmed(int id)
        {
            var qvOrder = await _context.Orders.SingleOrDefaultAsync(m => m.Id == id);
            _context.Orders.Remove(qvOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool qvOrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }



        public IActionResult TableOfVisitors()
        {
            return View();
        }
        [Route("/cabinet/order")]
        public IActionResult Request()
        {
            return View();
        }
        [Route("/cabinet/order/new")]
        public IActionResult CreateRequest()
        {
            return View();
        }

        [Route("/cabinet/order/1/show")]
        public IActionResult SelectRequest()
        {
            return View();
        }
        [Route("/cabinet/order/1/edit")]
        public IActionResult UpdateRequest()
        {
            return View();
        }
        public IActionResult Cabinet()
        {
            return View();
        }
    }
}
