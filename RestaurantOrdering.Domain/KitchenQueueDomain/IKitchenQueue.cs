using RestaurantOrdering.Domain.KitchenQueueDomain;
using RestaurantOrdering.Domain.OrdersDomain;

namespace RestaurantOrdering.Domain.KitchenQueueDomain
{
    public interface IKitchenQueue
    {
        KitchenArea KitchenFries { get; set; }

        KitchenArea KitchenGrill { get; set; }

        KitchenArea KitchenSalad { get; set; }

        KitchenArea KitchenDrink { get; set; }

        KitchenArea KitchenDessert { get; set; }

        void SendToKitchen(Item item);

    }
}
