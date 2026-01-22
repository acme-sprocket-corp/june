using June.Domain.Sprockets;

namespace June.Application.Sprockets
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISprocketRepository
    {
        /// <summary>
        /// Adds a sprocket to the persistence.
        /// </summary>
        /// <param name="sprocket">A <see cref="Sprocket"/> instance.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns></returns>
        Task<int> AddSprocket(Sprocket sprocket, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves all sprockets.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns></returns>
        Task<List<Sprocket>> GetAllSprockets(CancellationToken cancellationToken = default);
    }
}
