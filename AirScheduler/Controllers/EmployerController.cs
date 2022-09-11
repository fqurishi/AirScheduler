using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirScheduler.Models;
using AirScheduler.ViewModels;

namespace AirScheduler.Controllers
{
    public class EmployerController : Controller
    {
        // GET: Employer/Random
        public ActionResult Random()
        {
            var employer = new Employer() { Name = "Shrek" };
            var employees = new List<Employee>
            {
                new Employee {Name = "Employee 1"},
                new Employee {Name = "Employee 2"}
            };

            var viewModel = new RandomEmployeeViewModel
            {
                Employer = employer,
                Employees = employees
            };
            
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        // employers
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrEmpty(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("employer/Employee/{eid}")]
        public ActionResult ByEmployer(int eid)
        {
            return Content(eid + "");
        }
    }
}