using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SE.WebBackEnd.Controllers
{
    public class PostsController : Controller
    {
        [Route("Posts/New", Name="Posts")]
        public IActionResult Index()
        {
            return View();  
        }

        [Route("Posts/Create", Name="Posts.Create")]
        public IActionResult Create()
        {
            return View();
        }
    }
}