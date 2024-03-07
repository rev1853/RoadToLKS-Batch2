using EsemkaBakery.Database;

namespace EsemkaBakery.DTOs.Response
{
    public class CakeResponseDTO : Cake
    {
        public new string Description { set => base.Description = value; }
        public override ICollection<OrderItem> OrderItems { set => base.OrderItems = value; }
    }
}
