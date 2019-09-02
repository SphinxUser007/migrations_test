using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL1
{
   public class Blog
    {
        public int BlogId { get; set; }
        [Required]
        public string Url { get; set; }
        public List<Post> Posts { get; set; }
    }
}
