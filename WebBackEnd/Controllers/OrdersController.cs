﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class OrdersController : Controller
    {
        [Route("Orders", Name="Orders")]
        public IActionResult Index()
        {
            return View();
        }
    }
}