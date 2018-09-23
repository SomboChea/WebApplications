using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class TrackingController : Controller
    {
        [Route("Administrator/Tracking")]
        public IActionResult Index()
        {
            return View("~/Views/Administrators/Tracking/Index.cshtml");
        }
    }
}