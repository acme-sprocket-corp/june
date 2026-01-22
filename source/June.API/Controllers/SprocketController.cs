using June.Application.Sprockets;
using June.Domain.Sprockets;
using Microsoft.AspNetCore.Mvc;

namespace June.API.Controllers
{
    /// <inheritdoc />
    [ApiController]
    [Route("sprocket")]
    public class SprocketController : ControllerBase
    {
        private readonly ISprocketRepository _sprocketRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sprocketRepository"></param>
        public SprocketController(ISprocketRepository sprocketRepository)
        {
            _sprocketRepository = sprocketRepository;
        }

        /// <summary>
        /// Gets my sprocket.
        /// </summary>
        /// <returns>A <see cref="IActionResult"/>.</returns>
        [HttpGet("", Name = "GetAllSprockets")]
        [ProducesResponseType<IEnumerable<Sprocket>>(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllSprocket(CancellationToken cancellationToken = default)
        {
            var entities = await _sprocketRepository.GetAllSprockets(cancellationToken);

            return Ok(entities);
        }

        /// <summary>
        /// Adds a sprocket.
        /// </summary>
        /// <returns>A <see cref="IActionResult"/>.</returns>
        [HttpPost("", Name = "AddSprocket")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> AddSprocket(CancellationToken cancellationToken = default)
        {
            var sprocket = new Sprocket();

            await _sprocketRepository.AddSprocket(sprocket, cancellationToken);

            return Created(new Uri($"{sprocket.Id}", UriKind.Relative), sprocket);
        }
    }
}
