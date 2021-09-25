using System;
using System.Collections.Generic;

namespace Emp_DAL_Layer.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeRole { get; set; }
    }
}
