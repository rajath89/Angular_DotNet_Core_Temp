using Emp_DAL_Layer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_DAL_Layer
{
    public class EmployeeRepository
    {

        EmployeeDetailsContext context;

        public EmployeeRepository()
        {
            context = new EmployeeDetailsContext();
        }

        public Employee getEmployee(int empId)
        {

            Employee emp = null;
            try
            {
                emp = context.Employee.Find(empId);
            }
            catch (Exception ex)
            {

                emp = null;
            }
          

            return emp;
        }

    }
}
