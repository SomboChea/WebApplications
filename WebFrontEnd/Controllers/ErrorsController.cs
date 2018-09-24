using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class ErrorsController : Controller
    {
   
        [Route("Error.jsx")]
        public IActionResult ErrorPage(string code)
        {
            switch (code)
            {
                case "404":
                    Response.StatusCode = 404;
                    return View("Errors/E_404");
                case "403":
                    Response.StatusCode = 403;
                    return View("Errors/E_403");
                case "500":
                    Response.StatusCode = 500;
                    return View("Errors/E_500");
                case "502":
                    Response.StatusCode = 502;
                    return View("Errors/E_502");
                default:
                    Response.StatusCode = 404;
                    return ErrorPage("404");
            }
        }
    }
}