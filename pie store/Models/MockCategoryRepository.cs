
namespace pie_store.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category> {
            new Category { CategoryId = 1, CategoryName = "Fruit pies", Description = "All-fruity pies"},
            new Category{ CategoryId = 2, CategoryName = "Chees cakes", Description= "Chees cakes" } ,
            new Category{ CategoryId = 2, CategoryName = "Chees cakes", Description= "Chees cakes" } ,
        };

    }
}
