namespace SocialMedia.Models
{
    public class Reply : Comment
    {
        [Key]
        public int Id { get; set;}
        
        // foreign key to comment via id w/ virtual comment
        [Required]
        [ForeignKey("Comment")]
        public int CommentId { get; set;}
        
        [Required]
        public string Text { get; set;}

        // Guid AuthorId
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set;}

    }
}