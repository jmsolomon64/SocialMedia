using Microsoft.EntityFrameworkCore; //needed to use DbContext
using SocialMedia.Models;

namespace SocialMediaAPI
{
    public class SocialMediaDbContext : DbContext //Class inherits from DbContext class
    {
        public SocialMediaDbContext(DbContextOptions<SocialMediaDbContext>options): base(options) {} //I canno begin to explain this but it should work. more info here
        //https://elevenfifty.instructure.com/courses/883/pages/rr-api-2-dot-02-ef-dbcontext-setup-copy?module_item_id=88445

        public DbSet<Comment> Comments {get; set;} //database set representing Comment table
        public DbSet<Like> Likes {get; set;}//db set for Like Table
        public DbSet<Post> Posts {get; set;} //db set for Post table
        public DbSet<Reply> Replies {get; set;} //db set for Reply table
        public DbSet<User> Users {get; set;} //db set for User table
    }
}