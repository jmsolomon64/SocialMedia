using Microsoft.AspNetCore.Mvc;//needed to gain inheritance to the controller class

namespace SocialMedia.Controllers
{
    [ApiController] //gives dotnet heads up that this controller is an API controller not MVC
    [Route("[controller]")] //lets dotnet know what url access this controller
    public class PostController : Controller //Postcontroller inherits from Controller
    {
        
    }
}