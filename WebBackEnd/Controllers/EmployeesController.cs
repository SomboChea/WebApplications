using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class EmployeesController : Controller
    {
        [Route("Employees/Manage", Name="Employees")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Employees/Teams", Name="Employees.Teams")]
        public IActionResult Teams()
        {
            return View();
        }

        [Route("Employees/Contact", Name="Employees.Contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}