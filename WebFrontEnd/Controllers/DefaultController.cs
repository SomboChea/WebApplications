using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class DefaultController : Controller
    {
        [Route("", Name="Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About", Name="About")]
        public IActionResult About() 
        {
            return View();
        }

        [Route("Contact", Name="Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Promotions", Name="Promotion")]
        public IActionResult Promotion()
        {
            return View();
        }

        [Route("Categories", Name="Category")]
        public IActionResult Category() 
        {
            return View();
        }

        [Route("Help/FAQ", Name="Faq")]
        public IActionResult Faq()
        {
            return View();
        }
    }
}