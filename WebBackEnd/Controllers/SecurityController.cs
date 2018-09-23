using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class SecurityController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [Route("Security/Groups")]
        public IActionResult Groups()
        {
            return View();
        }

        [Route("Security/Roles")]
        public IActionResult Roles()
        {
            return View();
        }

        [Route("Security/Logs")]
        public IActionResult Logs()
        {
            return View();
        }

        [Route("Security/Blocks")]
        public IActionResult Blocks()
        {
            return View();
        }
    }
}