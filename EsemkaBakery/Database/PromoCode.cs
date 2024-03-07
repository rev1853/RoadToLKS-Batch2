using Microsoft.EntityFrameworkCore;

namespace EsemkaBakery.Database
{
    [PrimaryKey("PromoCodeID")]
    public class PromoCode
    {
        public int PromoCodeID { get; set; }
        public string Code { get; set; } = string.Empty;
        public int Percentage { get; set; }
        public decimal Max { get; set; }
        public DateTime ValidUntil { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = [];
    }
}
