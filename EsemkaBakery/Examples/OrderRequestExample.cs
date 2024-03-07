using EsemkaBakery.DTOs.Request;
using Swashbuckle.AspNetCore.Filters;

namespace EsemkaBakery.Examples
{
    public class OrderRequestExample : IExamplesProvider<OrderRequestDTO>
    {
        public OrderRequestDTO GetExamples()
        {
            return new OrderRequestDTO
            {
                UserID = 1,
                OrderDate = DateTime.Now,
                DiscountTotal = 6.624m,
                PromoCodeID = 2,
                OrderItems = [
                    new OrderItemRequestDTO {
                        CakeID = 1,
                        Quantity = 3,
                        Subtotal = 13.17m
                    },
                    new OrderItemRequestDTO {
                        CakeID = 3,
                        Quantity = 5,
                        Subtotal = 19.95m
                    }
                    ]
            };
        }
    }
}
