using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class ProductsController : Controller
    {
        [Route("Administrator/Products", Name="AdminProduct")]
        public IActionResult Index()
        {
            return View("~/Views/Administrators/Products/Index.cshtml");
        }
    }
}