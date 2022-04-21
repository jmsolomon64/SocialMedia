using System.ComponentModel.DataAnnotations; //used for all notations, but foreign key
using System.ComponentModel.DataAnnotations.Schema; //used to access foreign key notation

namespace SocialMedia.Models 
{
    public class Post 
    {
        [Key] //denotes Primary key
        public int Id {get; set;}
        [Required] //denotes required property (not needed for primary key)
        [ForeignKey("User")] //denotes foreign key
        public int UserId {get; set;} 
        [Required]
        public string PostContent {get; set;}
        [Required]
        [MaxLength(281)] //denotes max length of characters for string in property
        public DateTime DatePosted {get; set;}
        [Required]
        public virtual List<Like> Likes {get; set;} //property is a list of likes
        [Required]
        public virtual List<Reply> Reply {get; set;}  //property is a list of replies
    }
}