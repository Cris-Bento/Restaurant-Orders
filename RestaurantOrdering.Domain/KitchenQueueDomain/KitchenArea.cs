using RestaurantOrdering.Domain.OrdersDomain;

namespace RestaurantOrdering.Domain.KitchenQueueDomain
{
    public class KitchenArea
    {

        public string? Name { get; set; }
        public IList<Item>? Items { get; set; }

        public KitchenArea (string name) 
        {
            Name = name;
            Items = new List<Item>();
        }
    }
}
