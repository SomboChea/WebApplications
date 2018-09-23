using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        [Route("Administrator")]
        public IActionResult Index()
        {
            return View("~/Views/Administrators/Home/Index.cshtml");
        }
    }
}