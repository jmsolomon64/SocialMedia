using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialMedia.Models
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
        public virtual List<Like> Likes {get; set;} //property is a list of likes
        [Required]
        public virtual List<Reply> Reply {get; set;}  //property is a list of replies
    }
}