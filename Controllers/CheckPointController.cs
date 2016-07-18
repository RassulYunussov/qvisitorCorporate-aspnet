using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using qvisitorCorp.Data;

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
        public async Task<IActionResult> Entrances()
        {
            var applicationDbContext = _context.Entrances.Include(q => q.CheckPoint).Include(q => q.EntranceType).Include(q => q.Order).Include(q => q.Visitor);
            return View(await applicationDbContext.ToListAsync());
        }
        [Route("[controller]/entrances/[action]/{id}")]
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
        [Route("[controller]/entrances/[action]/{id}")]
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
        [Route("[controller]/hotentrances/[action]/{id}")]
        // GET: qvHotEntrances
        public async Task<IActionResult> Hotentrances()
        {
            var applicationDbContext = _context.HotEntrances.Include(q => q.Department);
            return View(await applicationDbContext.ToListAsync());
        }
        [Route("[controller]/hotentrances/[action]/{id}")]
        // GET: qvHotEntrances/Details/5
        public async Task<IActionResult> HotentrancesDetails(int? id)
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
        [Route("[controller]/hotentrances/[action]/{id}")]
        public async Task<IActionResult> HotentrancesEdit(int? id)
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

        public IActionResult Cabinet()
        {
            return View();
        }
        [Route("checkpoint")]
        public IActionResult KPP()
        {
            return View();
        }
        [Route("checkpoint/hotentrance")]
        public IActionResult CreateKPP()
        {
            return View();
        }

        public IActionResult SelectKPP()
        {
            return View();
        }
        [Route("checkpoint/entrance")]
        public IActionResult Visitors()
        {
            return View();
        }
        [Route("checkpoint/entrance/new")]
        public IActionResult CreateVisitors()
        {
            return View();
        }

        public IActionResult SelectVisitors()
        {
            return View();
        }

        public IActionResult UpdateVisitors()
        {
            return View();
        }
    }
}
