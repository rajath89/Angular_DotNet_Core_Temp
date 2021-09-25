using Emp_DAL_Layer;
using Emp_DAL_Layer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emp_Service.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : Controller
    {

        EmployeeRepository _repo;

        public EmployeeController()
        {
            _repo = new EmployeeRepository();
        }
        [HttpGet]
        public string test()
        {
            return "test route";
        }

        [HttpPost]
        public JsonResult GetEmployeeDetails(int empId)
        {
            Employee emp = new Employee();
            string message = "Employee not found";

            try
            {
                emp = _repo.getEmployee(empId);
            }

            catch(Exception ex)
            {
                emp = null;
            }

            if(emp!=null)
            {
                return Json(emp);
            }
            else
            {
                return Json(message);
            }
            

        }

    }
}
