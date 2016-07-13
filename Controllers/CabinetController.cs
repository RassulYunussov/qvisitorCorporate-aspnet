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
