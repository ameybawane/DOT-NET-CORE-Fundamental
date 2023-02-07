using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controller
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "Hello Web API Core.";
        }

        [HttpGet]
        public string AboutUs()
        {
            return "Welcome to AboutUs.";
        }

        public string ContactUs()
        {
            return "Welcome to ContactUs.";
        }

    }
}
