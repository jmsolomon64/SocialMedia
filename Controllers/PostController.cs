using Microsoft.AspNetCore.Mvc;//needed to gain inheritance to the controller class
using Microsoft.EntityFrameworkCore; //needed to use ToListAsync() method
using SocialMedia.Data;
using SocialMedia.Models; //needed to accessing classes in Models directory

namespace SocialMedia.Controllers
{
    [ApiController] //gives dotnet heads up that this controller is an API controller not MVC
    [Route("[controller]")] //lets dotnet know what url access this controller
    public class PostController : Controller //Postcontroller inherits from Controller
    {
        private SocialMediaDbContext _context; //instance of Social Media database

        [HttpPost] //indicates that this is a Post action

        public async Task<IActionResult> PostPost([FromForm] PostEdit model)
        {
            if (!ModelState.IsValid) //checks to see if model pushed in is invalid
            {
                return BadRequest(ModelState); //returns a bad request code indicating it's coming from an invalid model
            }

            _context.Posts.Add(new Post() //creates a new instance of Post inside of the Posts table
            {
                PostContent = model.PostContent //sets content of the new instance equal to the content 
            });

            await _context.SaveChangesAsync(); //saves changes made and pushes them to the db 

            return Ok(); //returns status code indicating request went well
        }

        [HttpGet] //Denotes Get actions
        public async Task<IActionResult> GetPosts()
        {
            var posts = await _context.Posts.ToListAsync(); //creates a list of all posts in the db
            return Ok(posts); //returns okay status as well as the list
        }

        [HttpGet] //denotes yet another get action 
        [Route("{id}")] //retrieves post by http/local/post/# (# = Postid primary key)
        public async Task<IActionResult> GetPostById(int id)
        {
            var post = await _context.Posts.FindAsync(id); //sets a variable to contain a post pulled by id from the db
            if (post == null) //checks to see if post is empty
            {
                return NotFound(); //returns a status code letting user know the post wasn't found
            }
            return Ok(post); //returns okay status as well as the post 
        }
    }
}