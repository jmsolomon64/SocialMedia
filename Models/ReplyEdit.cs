namespace SocialMedia.Models
{
    public class ReplyEdit
    {
        public string Text { get; set;}
        // Unsure if we need the below? How do we associate the reply with the comment? Likely via the route within the controller...
        public int CommentId { get; set;}
        // public int UserId { get; set;}
    }
}