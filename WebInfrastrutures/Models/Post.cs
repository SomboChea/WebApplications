using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SE.WebInfrastrutures.Models
{
    public class Post
    {
        public long Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Desc { get; set; }
        [Required]
        public string Content { get; set; }
        public int Poster { get; set; }

        public Post(long id, string title, string desc, string content, int poster)
        {
            Id = id;
            Title = title;
            Desc = desc;
            Content = content;
            Poster = poster;
        }
    }
}
