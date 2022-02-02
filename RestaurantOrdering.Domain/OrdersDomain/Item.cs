

namespace RestaurantOrdering.Domain.OrdersDomain
{
    public class Item
    {
        public string? Name { get; set; }

        public CategoriesDomain Category { get; set; }  
    }
}
