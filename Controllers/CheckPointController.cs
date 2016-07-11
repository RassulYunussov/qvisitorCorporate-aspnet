using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace qvisitorCorp.Controllers
{
    public class CheckPointController : Controller
    {
        
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
