using June.Domain.Sprockets;
using June.Infrastructure.DataAccess.Common;
using Microsoft.AspNetCore.Mvc;

namespace June.API.Controllers
{
    /// <inheritdoc />
    [ApiController]
    [Route("sprocket")]
    public class SprocketController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SprocketController(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets my sprocket.
        /// </summary>
        /// <returns>A <see cref="IActionResult"/>.</returns>
        [HttpGet]
        [ProducesResponseType<IEnumerable<Sprocket>>(StatusCodes.Status200OK)]
        public IActionResult GetAllSprocket()
        {
            var entities = _context.Sprockets.ToList();

            return Ok(entities);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AddSprocket()
        {
            var sprocket = new Sprocket();

            _context.Sprockets.Add(sprocket);

            _context.SaveChanges();

            return Created(new Uri($"{sprocket.Id}", UriKind.Relative), sprocket);
        }
    }
}
