using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class AuthController : Controller
    {
        [Route("Auth/Login", Name="Login")]
        public IActionResult Login()
        {
            return View("~/Views/Administrators/Auth/Login.cshtml");
        }

        [Route("Auth/Register", Name="Register")]
        public IActionResult Register()
        {
            return View("~/Views/Administrators/Auth/Register.cshtml");
        }

        [Route("Auth/Logout", Name="Logout")]
        public IActionResult Logout()
        {
            return RedirectToRoute("Home");
        }
    }
}