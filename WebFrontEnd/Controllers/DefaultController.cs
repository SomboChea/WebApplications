using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class DefaultController : Controller
    {
        [Route("About")]
        public IActionResult Index()
        {
            return View();
        }
    }
}