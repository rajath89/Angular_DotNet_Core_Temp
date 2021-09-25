using Emp_DAL_Layer;
using System;

namespace EmpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmployeeRepository repository = new EmployeeRepository();
            var emp = repository.getEmployee(1000);
            Console.WriteLine(emp);
        }
    }
}
