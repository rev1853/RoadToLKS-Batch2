using EsemkaBakery.Database;
using System.Text.Json.Serialization;

namespace EsemkaBakery.DTOs.Request
{
    public class OrderItemRequestDTO : OrderItem
    {
        [JsonIgnore]
        public new int OrderItemID { set => base.OrderItemID = value; }
        [JsonIgnore]
        public new int OrderID { set => base.OrderID = value; }
        [JsonIgnore]
        public override Order Order { set => base.Order = value; }
        [JsonIgnore]
        public override Cake Cake { set => base.Cake = value; }
    }
}
