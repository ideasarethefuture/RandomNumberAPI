using Microsoft.AspNetCore.Mvc;

namespace RandomNumberAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase
    {
        private readonly Random _rng = new();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_rng.Next(1, 101)); // Generate a random number between 1 and 100
        }
    }
}
