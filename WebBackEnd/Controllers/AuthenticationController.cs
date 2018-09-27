using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class AuthController : Controller
    {
        [Route("Auth/Login", Name="Login")]
        public IActionResult Index()
        {
            return View("Login");
        }

        [Route("Auth/Register", Name="Register")]
        public IActionResult Register()
        {
            return View("Register");
        }

        [Route("Auth/Signout", Name="Logout")]
        public IActionResult Signout()
        {
            return Redirect("~/Auth/Login");
        }
    }
}