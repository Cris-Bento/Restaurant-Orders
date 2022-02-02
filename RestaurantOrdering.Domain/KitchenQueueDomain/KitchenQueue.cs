using RestaurantOrdering.Domain.OrdersDomain;
using RestaurantOrdering.Domain.KitchenQueueDomain;

namespace RestaurantOrdering.Domain.KitchenQueueDomain
{
    public class KitchenQueue : IKitchenQueue
    {
        public KitchenArea KitchenFries { get; set; }

        public KitchenArea KitchenGrill { get; set; }

        public KitchenArea KitchenSalad { get; set; }

        public KitchenArea KitchenDrink { get; set; }

        public KitchenArea KitchenDessert { get; set; }
        
        public KitchenQueue () 
    { 
     
            KitchenFries = new KitchenArea("fries");

            KitchenGrill = new KitchenArea("grill");

            KitchenSalad = new KitchenArea("salad");

            KitchenDrink = new KitchenArea("drink");

            KitchenDessert = new KitchenArea("dessert");
    }

    public void SendToKitchen(Item item)
        {
            switch(item.Category)
            {

                case CategoriesDomain.Fries:
                    KitchenFries.Items.Add(item);
                    break; 
                    
                case CategoriesDomain.Grill:
                    KitchenGrill.Items.Add(item);
                    break;

                case CategoriesDomain.Salad:
                    KitchenSalad.Items.Add(item);
                    break;

                case CategoriesDomain.Drink:
                    KitchenDrink.Items.Add(item);
                    break;

                case CategoriesDomain.Dessert:
                    KitchenDessert.Items.Add(item);
                    break;

            }
        }


    }
}

