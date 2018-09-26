using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class MediaController : Controller
    {
        [Route("Administrator/Media", Name="AdminMedia")]
        public IActionResult Index()
        {
            return View("~/Views/Administrators/Media/Index.cshtml");
        }

        [Route("Administrator/Media/CreateSlider", Name="AdminNewSlider")]
        public IActionResult CreateSlider()
        {
            return View();
        }
    }
}