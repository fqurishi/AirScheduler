using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirScheduler.Models;

namespace AirScheduler.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employee/Random
        public ViewResult Random()
        {
            var employee = new Employee() { Name = "Shrek" };
            
            return View(employee);
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        // employees
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrEmpty(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("employees/Employer/{eid}")]
        public ActionResult ByEmployer(int eid)
        {
            return Content(eid + "");
        }
    }
}