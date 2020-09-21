namespace CustomerRelationship.Infrastructure.Model.BaseModel
{
    /// <summary>
    /// Used as paginated response
    /// </summary>
    /// <typeparam name="T">Type of items</typeparam>
    public class PaginatedResponseModel<T>
    {
        /// <summary>
        /// Number of items
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Items of T
        /// </summary>
        public T Items { get; set; }
    }
}
