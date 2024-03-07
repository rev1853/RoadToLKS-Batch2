using Microsoft.EntityFrameworkCore;

namespace EsemkaBakery.Database
{
    [PrimaryKey("OrderItemID")]
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int CakeID { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
        public virtual Order Order { get; set; } = new Order();
        public virtual Cake Cake { get; set; } = new Cake();
    }
}
