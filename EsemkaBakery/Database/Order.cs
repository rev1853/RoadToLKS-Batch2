using Microsoft.EntityFrameworkCore;

namespace EsemkaBakery.Database
{
    [PrimaryKey("OrderID")]
    public partial class Order
    {
        public virtual int OrderID { get; set; }
        public int UserID { get; set; }
        public int PromoCodeID { get; set; }
        public virtual string OrderCode { get; set; } = string.Empty;
        public decimal DiscountTotal { get; set; }
        public string OrderDate { get; set; } = string.Empty;
        public virtual PromoCode PromoCode { get; set; } = new PromoCode();
        public virtual User User { get; set; } = new User();
        public virtual ICollection<OrderItem> OrderItems { get; set; } = [];
    }
}
