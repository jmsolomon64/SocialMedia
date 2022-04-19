using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMediaAPI.Models
{
    public class Post 
    {
        [Key] //denotes Primary key
        public int Id {get; set;}
        [ForeignKey("User")]
        public int UserId {get; set;}
        [Required]
        public string PostContent {get; set;}
        [Required]
        [MaxLength(281)]
        public DateTime DatePosted {get; set;}
        [Required]
        public int Likes {get; set;}
        [Required]
        public int Comments {get; set;}
    }
}