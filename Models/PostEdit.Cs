using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models 
{
    public class PostEdit 
    {
        [Required]
        [MaxLength(281)]
        public string PostContent {get; set;}
    }
}