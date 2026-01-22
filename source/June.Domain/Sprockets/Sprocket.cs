namespace June.Domain.Sprockets
{
    /// <summary>
    /// Default entity for application.
    /// </summary>
    public class Sprocket
    {
        /// <summary>
        /// 
        /// </summary>
        public Sprocket()
        {
            Id = Guid.CreateVersion7();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
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
