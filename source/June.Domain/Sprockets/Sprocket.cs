namespace June.Domain.Sprockets
{
    /// <summary>
    /// Default entity for application.
    /// </summary>
    public class Sprocket
    {
        public Sprocket()
        {
            Id = Guid.CreateVersion7();
        }

        public Sprocket(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        public Guid Id { get; }
    }
}
