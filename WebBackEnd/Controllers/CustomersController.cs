using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class CustomersController : Controller
    {
        [Authorize]
        [Route("Customers")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Customers/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("Customers/Blocks")]
        public IActionResult Blocks()
        {
            return View();
        }
    }
}