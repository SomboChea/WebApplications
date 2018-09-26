using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class PostsController : Controller
    {
        [Route("Administrator/Posts", Name="AdminPost")]
        public IActionResult Index()
        {
            return View("~/Views/Administrators/Posts/Index.cshtml");
        }

        [Route("Administrator/Posts/New", Name="AdminNewPost")]
        public IActionResult New()
        {
            return View("~/Views/Administrators/Posts/New.cshtml");
        }
    }
}