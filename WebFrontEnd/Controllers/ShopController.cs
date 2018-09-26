using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class ShopController: Controller
    {
        [Route("Shop", Name="Shop")]
        public IActionResult Index() 
        {
            return View();
        }
    }
}