using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class UsersController : Controller
    {
        [Route("Users", Name="Users")]
        public IActionResult Index()
        {
            return View();
        }
    }
}