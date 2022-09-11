using AirScheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirScheduler.ViewModels
{
    public class RandomEmployeeViewModel
    {
        public Employer Employer { get; set; }
        public List<Employee> Employees { get; set; }
    }
}