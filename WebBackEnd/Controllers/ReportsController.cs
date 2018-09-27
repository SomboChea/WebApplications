using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class ReportsController : Controller
    {
        [Route("Reports", Name="Reports")]
        public IActionResult Index()
        {
            return View();
        }
    }
}