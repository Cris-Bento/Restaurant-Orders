using System.Collections;

namespace RestaurantOrdering.Domain.OrdersDomain
{
    public class Order
    {

        public int Number { get; set; }

        public List<Item> Items { get; set; }

    }
}
