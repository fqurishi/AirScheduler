using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirScheduler.Models;

namespace AirScheduler.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee/Random
        public ActionResult Random()
        {
            var employee = new Employee() { Name = "Shrek" };
            return View(employee);
        }
    }
}