using Microsoft.EntityFrameworkCore;

namespace EsemkaBakery.Database
{
    [PrimaryKey("UserID")]
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public virtual ICollection<Order> Orders { get; set; } = [];
    }
}
