using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class SecurityController : Controller
    {

        [Route("Security", Name="Security")]        
        public IActionResult Index()
        {
            return View();
        }

        [Route("Security/Groups", Name="Security.Groups")]
        public IActionResult Groups()
        {
            return View();
        }

        [Route("Security/Roles", Name="Security.Roles")]
        public IActionResult Roles()
        {
            return View();
        }

        [Route("Security/Logs", Name="Security.Logs")]
        public IActionResult Logs()
        {
            return View();
        }

        [Route("Security/Blocks", Name="Security.Blocks")]
        public IActionResult Blocks()
        {
            return View();
        }
    }
}