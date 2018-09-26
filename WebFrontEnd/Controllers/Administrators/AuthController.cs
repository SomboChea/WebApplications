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
        public IActionResult Index()
        {
            return View("~/Views/Administrators/Auth/Login.cshtml");
        }

        [Route("Auth/Register", Name="Register")]
        public IActionResult Register()
        {
            return View("~/Views/Administrators/Auth/Register.cshtml");
        }

        [Route("Auth/ResetPassword", Name="ResetPassword")]
        public IActionResult ResetPassword()
        {
            return View("~/Views/Administrators/Auth/ResetPassword.cshtml");
        }
    }
}