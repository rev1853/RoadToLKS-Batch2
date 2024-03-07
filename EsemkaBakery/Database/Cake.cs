using Microsoft.EntityFrameworkCore;

namespace EsemkaBakery.Database
{
    [PrimaryKey("CakeID")]
    public class Cake
    {
        public int CakeID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        public virtual ICollection<OrderItem> OrderItems { get; set; } = [];
    }
}
