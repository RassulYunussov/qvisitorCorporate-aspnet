using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using qvisitorCorp.Data;

namespace qvisitorCorp.Controllers
{
    public class CabinetController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CabinetController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ListOfOrders
        public async Task<IActionResult> Orders()
        {
            var applicationDbContext = _context.Orders.Include(q => q.OrderStatus).Include(q => q.OrderType);
            return View(await applicationDbContext.ToListAsync());
        }

         // GET: qvOrders/Details/5
        [Route("[controller]/orders/[action]/{id}")]
        public async Task<IActionResult> OrderDetails(int? id)
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
