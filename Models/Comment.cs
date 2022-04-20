using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class Comment
    {
        [ForeignKey("Post")]
        [ForeignKey("User")]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]        
    }
}