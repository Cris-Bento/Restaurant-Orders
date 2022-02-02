using Microsoft.AspNetCore.Mvc;
using RestaurantOrdering.Domain.KitchenQueueDomain;
using RestaurantOrdering.Domain.OrdersDomain;

namespace RestaurantOrdering.Controllers
{
    public class KitchenController : Controller
    {

            private readonly IKitchenQueue _kitchenQueue;

            public KitchenController(IKitchenQueue kitchenQueue)
            {
                _kitchenQueue  = kitchenQueue;
            }

            [HttpPost("items/")]
            public async Task<IActionResult> Post([FromBody] Order order)
           {
                try
                {
                    foreach (var item in order.Items)
                    {
                            _kitchenQueue.SendToKitchen(item);

                    }

                  return Ok();

                }

                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpGet("kitchenarea/")]
            public async Task<IActionResult> Get()
            {
                try
                {
                    var list = new List<KitchenArea>();
                    list.Add(_kitchenQueue.KitchenFries);
                    list.Add(_kitchenQueue.KitchenGrill);
                    list.Add(_kitchenQueue.KitchenSalad);
                    list.Add(_kitchenQueue.KitchenDrink);
                    list.Add(_kitchenQueue.KitchenDessert);


                    return Ok(list);

                }

                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpGet("kitchenarea/{name}")]
            public async Task<IActionResult> Get(string name)
            {
                try
                {
                    switch (name)
                    {
                        case "fries":
                            return Ok(_kitchenQueue.KitchenFries);

                        case "grill":
                            return Ok(_kitchenQueue.KitchenGrill);

                        case "salad":
                            return Ok(_kitchenQueue.KitchenSalad);

                        case "drink":
                            return Ok(_kitchenQueue.KitchenDrink);

                        case "dessert":
                            return Ok(_kitchenQueue.KitchenDessert);

                        default:
                            return NotFound("This kitchen area does not exist!");
                    }
                    return Ok();

                }

                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

        
    }
}
