namespace CustomerManager.Infrastructure.Model.BaseModel
{
    /// <summary>
    /// Used as paginated request
    /// </summary>
    public class PaginatedRequestModel
    {
        /// <summary>
        /// Items to take
        /// </summary>
        public int? Take { get; set; }

        /// <summary>
        /// Items to skip
        /// </summary>
        public int? Skip { get; set; }
    }
}
