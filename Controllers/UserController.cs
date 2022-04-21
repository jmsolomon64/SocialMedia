using Microsoft.AspNetCore.Mvc;//needed to gain inheritance to the controller class
using Microsoft.EntityFrameworkCore;
using SocialMedia.Models;

namespace SocialMedia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private SocialMediaDbContext _db;
        public UserController(SocialMediaDbContext db) {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromForm] UserEdit newUser)
        {
            User user = new User()
            {
                Username = newUser.Username,
                Email = newUser.Email,
                Password = newUser.Password
            };

            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _db.Users.ToListAsync();
            return Ok(users);
        }
    }
}