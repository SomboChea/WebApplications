using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class DiscountsController : Controller
    {
        [Route("Discounts", Name="Discounts")]
        public IActionResult Index()
        {
            return View();
        }
    }
}