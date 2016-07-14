using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/*
 [Route(“reviews/{reviewId}”)]
    public ActionResult Show(int reviewId) { … }
      */
namespace qvisitorCorp.Controllers
{
    public class AdminController : Controller
    {
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
        [Route("admin/company/{companyId}/show")]
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
