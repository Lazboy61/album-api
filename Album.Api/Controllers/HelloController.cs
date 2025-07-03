using Microsoft.AspNetCore.Mvc;
using Album.Api.Services;

namespace Album.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  // Ik raad aan om 'api/' prefix toe te voegen
    public class HelloController : ControllerBase
    {
        private readonly GreetingService _greetingService;

        public HelloController()
        {
            _greetingService = new GreetingService();
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string? name)
        {
            return Ok(_greetingService.Greet(name));
        }
    }
}