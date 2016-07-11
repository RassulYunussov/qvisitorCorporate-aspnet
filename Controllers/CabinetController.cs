using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace qvisitorCorp.Controllers
{
    public class CabinetController : Controller
    {
        public IActionResult TableOfVisitors()
        {
            return View();
        }

        public IActionResult Request()
        {
            return View();
        }

        public IActionResult CreateRequest()
        {
            return View();
        }

        public IActionResult SelectRequest()
        {
            return View();
        }

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
