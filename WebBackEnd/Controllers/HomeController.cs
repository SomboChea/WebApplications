using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SE.WebBackEnd.Models;

namespace SE.WebBackEnd.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [AllowAnonymous]
        [Route("Error.jsx")]
        public IActionResult ErrorPage(string code)
        {
            switch(code)
            {
                case "404":
                    Response.StatusCode = 404;
                    return View("E_404");
                case "403":
                    Response.StatusCode = 403;
                    return View("E_403");
                case "500":
                    Response.StatusCode = 500;
                    return View("E_500");
                case "502":
                    Response.StatusCode = 502;
                    return View("E_502");
                default:
                    Response.StatusCode = 404;
                    return ErrorPage("404");
            }
        }
    }
}
