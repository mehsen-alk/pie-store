namespace pie_store.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
