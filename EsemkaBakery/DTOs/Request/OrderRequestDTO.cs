using EsemkaBakery.Database;
using System.Text.Json.Serialization;

namespace EsemkaBakery.DTOs.Request
{
    public class OrderRequestDTO : Order
    {
        [JsonIgnore]
        public new string OrderCode { get => base.OrderCode; set => base.OrderCode = value; }
        [JsonIgnore]
        public new int OrderID { get => base.OrderID; set => base.OrderID = value; }
        public new DateTime OrderDate { get => DateTime.Parse(base.OrderDate); set => base.OrderDate = value.ToString(); }
        [JsonIgnore]
        public override PromoCode PromoCode { get => base.PromoCode; set => base.PromoCode = value; }
        [JsonIgnore]
        public override User User { get => base.User; set => base.User = value; }

        public new ICollection<OrderItemRequestDTO> OrderItems { set => base.OrderItems = value.Select(e => Converter.ConvertClass<OrderItem, OrderItemRequestDTO>(e)!).ToList(); get => base.OrderItems.Select(e => Converter.ConvertClass<OrderItemRequestDTO, OrderItem>(e)!).ToList(); }
    }
}
