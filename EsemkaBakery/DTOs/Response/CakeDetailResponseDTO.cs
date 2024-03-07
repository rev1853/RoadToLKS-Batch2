using EsemkaBakery.Database;

namespace EsemkaBakery.DTOs.Response
{
    public class CakeDetailResponseDTO : Cake
    {
        public override ICollection<OrderItem> OrderItems { set => base.OrderItems = value; }
    }
}
