using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class SaleController: Controller
    {
        [Route("Sale", Name="Sale")]
        public IActionResult Index() 
        {
            return View();
        }

        [Route("Sale/New", Name="NewSale")]
        public IActionResult NewPost()
        {
            return View("~/Views/Sale/New.cshtml");
        }
    }
}