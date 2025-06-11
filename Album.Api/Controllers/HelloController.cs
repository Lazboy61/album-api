using Microsoft.AspNetCore.Mvc;
using Album.Api.Services;

namespace Album.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly GreetingService _greetingService;

        public HelloController()
        {
            _greetingService = new GreetingService();
        }


        [HttpGet]
        public IActionResult GetGreeting([FromQuery] string? name)
        {
            var message = _greetingService.Greet(name);
            return Ok(message);
        }

    }
}
