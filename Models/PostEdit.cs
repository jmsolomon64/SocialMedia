using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models
{
    public class PostEdit // Model for editting a social media post
    {
        [MaxLength(281)] 
        // Does this max length still need to be here??
        public string PostContent {get; set;} 
        // PostContent is the container for the new post
        public DateTime DatePosted {get; set;} 
        // New timestamp because the post was editted??
    }
}