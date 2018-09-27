using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class TrackingController : Controller
    {
        [Route("Tracking", Name="Tracking")]
        public IActionResult Index()
        {
            return View();
        }
    }
}