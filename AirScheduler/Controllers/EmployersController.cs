using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirScheduler.Models;
using AirScheduler.ViewModels;

namespace AirScheduler.Controllers
{
    public class EmployersController : Controller
    {
        public ViewResult Index()
        {
            var employers = GetEmployers();

            return View(employers);
        }

        private IEnumerable<Employer> GetEmployers()
        {
            return new List<Employer>
            {
                new Employer { Id = 1, Name = "Shrek" },
                new Employer { Id = 2, Name = "Wall-e" }
            };
        }

        // GET: Employers/Random
        public ActionResult Random()
        {
            var employer = new Employer() { Name = "Shrek!" };
            var employees = new List<Employee>
            {
                new Employee { Name = "Employee 1" },
                new Employee { Name = "Employee 2" }
            };

            var viewModel = new RandomEmployeeViewModel
            {
                Employer = employer,
                Employees = employees
            };

            return View(viewModel);
        }



    }
}