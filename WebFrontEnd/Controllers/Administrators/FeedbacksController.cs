using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebFrontEnd.Controllers
{
    public class FeedbacksController : Controller
    {
        [Route("Administrator/Feedbacks")]
        public IActionResult Index()
        {
            return View("~/Views/Administrators/Feedbacks/Index.cshtml");
        }
    }
}