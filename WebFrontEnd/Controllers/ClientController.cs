using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class ClientController: Controller
    {
        [Route("Client/Profile", Name="Profile")]
        public IActionResult Index() 
        {
            return View();
        }

        [Route("Client/Cart", Name="Cart")]
        public IActionResult Cart()
        {
            return View();
        }

        [Route("Client/Checkout", Name="Checkout")]
        public IActionResult Checkout()
        {
            return View();
        }

        [Route("Client/Tracking", Name="Tracking")]
        public IActionResult TrackingOrder() 
        {
            return View();
        }

        [Route("Client/Returns", Name="Return")]
        public IActionResult ReturnOrder()
        {
            return View();
        }

        [Route("Client/Shipping", Name="Shipping")]
        public IActionResult Shipping()
        {
            return View();
        }
    }
}