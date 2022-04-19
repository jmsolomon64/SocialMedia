using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models
{
    public class User
    {
        [Key]
        public int Id { get; set;}
        [Required]
        public string Username { get; set;}
        [Required]
        public string Email { get; set;}
        [Required]
        public string Password { get; set;}
        [Required]
        public DateTime DateJoined { get; set;}
        
    }
}