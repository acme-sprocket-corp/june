using Microsoft.AspNetCore.Mvc;

namespace June.API.Controllers
{
    /// <inheritdoc />
    [ApiController]
    [Route("sprocket")]
    public class SprocketController : ControllerBase
    {
        /// <summary>
        /// Gets my sprocket.
        /// </summary>
        /// <returns>A <see cref="IActionResult"/>.</returns>
        [HttpGet]
        [ProducesResponseType<string>(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok("hello!");
        }
    }
}
