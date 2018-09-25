using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class DefaultController : Controller
    {
        //[Route("About")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About", Name ="Home.About")]
        public IActionResult About() 
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Blog")]
        public IActionResult Blog()
        {
            return View();
        }
    }
}