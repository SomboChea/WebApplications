using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class ReportsController : Controller
    {
        [Route("Administrator/Reports")]
        public IActionResult Index()
        {
            return View("~/Views/Administrators/Reports/Index.cshtml");
        }

        [Route("Administrator/Reports/Transactions")]
        public IActionResult Transactions()
        {
            return View("~/Views/Administrators/Reports/Transactions.cshtml");
        }
    }
}