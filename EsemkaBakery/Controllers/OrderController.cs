using EsemkaBakery.Database;
using EsemkaBakery.DTOs.Request;
using EsemkaBakery.DTOs.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace EsemkaBakery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController(EsemkaBakeryContext context) : ControllerBase
    {
        [Tags("Order Page")]
        [HttpGet("PromoCode/{code}")]
        public async Task<ActionResult<PromoCodeResponseDTO>> GetCode(string code)
        {
            var promo = await context.PromoCodes.Where(e => e.Code == code && e.ValidUntil > DateTime.Now).FirstOrDefaultAsync();
            if (promo == default) return NotFound(new ErrorResponseDTO
            {
                Message = "Promo Code is not found or already expired"
            });

            return Ok(Converter.ConvertClass<PromoCodeResponseDTO, PromoCode>(promo));
        }

        [Tags("Order Page")]
        [HttpPost]
        public async Task<ActionResult<OrderSuccessResponseDTO>> Order(OrderRequestDTO data)
        {
            data.OrderID = 0;
            decimal total = 0;

            foreach (var item in data.OrderItems)
            {
                var cake = await context.Cakes.FindAsync(item.CakeID);
                if (cake == default) return NotFound(new ErrorResponseDTO
                {
                    Message = $"No cake found with id {item.CakeID}"
                });

                var subtotal = cake.Price * item.Quantity;
                if (subtotal != item.Subtotal) return BadRequest(new ErrorResponseDTO
                {
                    Message = $"Subtotal for cake id {item.CakeID} is not correct"
                });

                total += subtotal;
            }

            if (data.PromoCodeID != default)
            {
                var promoCode = await context.PromoCodes.FindAsync(data.PromoCodeID);
                if (promoCode == default) return NotFound(new ErrorResponseDTO
                {
                    Message = "Promo Code ID is not valid"
                });

                var discount = total * promoCode.Percentage / 100;
                if (discount > promoCode.Max)
                {
                    if (data.DiscountTotal != promoCode.Max)
                        return BadRequest(new ErrorResponseDTO
                        {
                            Message = "Discount Total is not correct"
                        });
                }
                else {
                    if (data.DiscountTotal != discount) 
                        return BadRequest(new ErrorResponseDTO
                        {
                            Message = "Discount Total is not correct"
                        });
                }
            }

            data.OrderCode = GenerateRandomString(10);
            context.Orders.Add(data);
            await context.SaveChangesAsync();

            return Ok(new OrderSuccessResponseDTO
            {
                OrderCode = data.OrderCode
            });
            
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> Detail(string code)
        {
            return Ok(await context.Orders
                .Where(e => e.OrderCode == code)
                .Include(e => e.User)
                .Include(e => e.OrderItems)
                .ThenInclude(e => e.Cake)
                .Select(e => new
                {
                    e.OrderID,
                    e.OrderDate,
                    e.OrderCode,
                    e.DiscountTotal,
                    User = new
                    {
                        e.User.UserID,
                        e.User.Username
                    },
                    Items = e.OrderItems.Select(f => new
                    {
                        CakeName = f.Cake.Name,
                        Qty = f.Quantity,
                        f.Subtotal
                    })

                }).FirstOrDefaultAsync());
        }

        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            char[] randomArray = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(randomArray);
        }
    }
}
