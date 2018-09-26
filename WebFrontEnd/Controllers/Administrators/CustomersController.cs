using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class CustomersController : Controller
    {
        [Route("Administrator/Customers", Name="AdminCustomer")]
        public IActionResult Index()
        {
            return View("~/Views/Administrators/Customers/Index.cshtml");
        }
    }
}