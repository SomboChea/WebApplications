using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class ProfileController : Controller
    {
        [Route("Administrator/Profile", Name="AdminProfile")]
        public IActionResult Index()
        {
            return View("~/Views/Administrators/Profile/Index.cshtml");
        }
    }
}