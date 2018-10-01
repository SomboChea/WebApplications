using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers.FrontEnd
{
    public class HomeController : Controller
    {
        [Route("/Beta", Name="HomeBeta")]
        public IActionResult Index()
        {
            return View("~/Views/FrontEnd/Home/Index.cshtml");
        }
    }
}