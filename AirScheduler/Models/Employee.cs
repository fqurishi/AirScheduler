using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirScheduler.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int  EmployerId { get; set; }
        public AccountType AccountType { get; set; }
        
    }
}