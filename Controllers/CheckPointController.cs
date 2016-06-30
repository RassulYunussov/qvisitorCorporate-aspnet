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

        public IActionResult KPP()
        {
            return View();
        }

        public IActionResult CreateKPP()
        {
            return View();
        }

        public IActionResult SelectKPP()
        {
            return View();
        }

        public IActionResult Visitors()
        {
            return View();
        }
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
