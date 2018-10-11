using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SE.WebInfrastrutures.Data;
using SE.WebInfrastrutures.Models;
using SE.WebInfrastrutures.Repositories;

namespace SE.WebServices.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly SEDbContext _context;
        private readonly Repository<Post> repository;

        public PostsController(SEDbContext context) => repository = new Repository<Post>(context);

        [HttpGet]
        public IEnumerable<Post> GetPosts()
        {
            return repository.GetAll();
            //return _context.Posts;
        }

        [HttpGet("{id}")]
        public Post GetPostById(long id)
        {
            return repository.GetById(id);
            //return _context.Posts.Find(id);
        }

        private IList<Post> Data { get; set; }

        [HttpGet("search")]
        public IEnumerable<Post> SearchPosts(string query)
        {
            var posts = from m in repository.GetAll()
                        select m;

            if (!String.IsNullOrEmpty(query))
                return posts.Where(s => s.Title.Contains(query));

            return null;
            //var posts = from m in _context.Posts
            //            select m;
            //if(!String.IsNullOrEmpty(query))
            //{
            //    posts = posts.Where(s => s.Title.Contains(query));
            //}

            //Data = posts.ToList();
            //return Data;    
        }
        [HttpGet("test")]
        public string Posts()
        {
            return "hell";
        }
        
    }
}