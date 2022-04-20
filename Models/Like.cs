namespace SocialMedia.Models
{
    public class Like
    {
        [Key]
        public int Id { get; set;}

        [Required]
        [ForeignKey("Post")]
        public int PostId { get; set;}
        [ForeignKey("User")]
        public int UserId {get; set;}
    }
}