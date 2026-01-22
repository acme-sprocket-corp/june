using June.Application.Sprockets;
using June.Domain.Sprockets;
using June.Infrastructure.DataAccess.Common;
using MongoDB.Driver;

namespace June.Infrastructure.DataAccess.Sprockets
{
    /// <inheritdoc />
    public class SprocketRepository : ISprocketRepository
    {
        private readonly IMongoDatabase _database;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client">An instance of the <see cref="MongoClient"/> class.</param>
        public SprocketRepository(MongoClient client)
        {
            _database = client.GetDatabase(MongoConstants.MongoDb);
        }

        /// <inheritdoc />
        public async Task<int> AddSprocket(Sprocket sprocket, CancellationToken cancellationToken = default)
        {
            await _database
                .GetCollection<Sprocket>(nameof(Sprocket))
                .InsertOneAsync(sprocket, new InsertOneOptions(), cancellationToken);

            return 1;
        }

        /// <inheritdoc/>
        public async Task<List<Sprocket>> GetAllSprockets(CancellationToken cancellationToken = default)
        {
            return await _database
                .GetCollection<Sprocket>(nameof(Sprocket))
                .Find(FilterDefinition<Sprocket>.Empty)
                .ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
