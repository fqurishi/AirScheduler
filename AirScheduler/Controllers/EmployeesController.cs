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
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }


    }
}