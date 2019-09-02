using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL1
{
   public class Post
    {
        public int PostId { get; set; }
        [Required]
        [StringLength(120)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public int BlogId { get; set; }
        [ForeignKey(nameof(BlogId))]
        public Blog Blog { get; set; }
    }
}
