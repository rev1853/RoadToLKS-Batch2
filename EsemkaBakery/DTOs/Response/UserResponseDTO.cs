using EsemkaBakery.Database;
using System.Text.Json.Serialization;

namespace EsemkaBakery.DTOs.Response
{
    public class UserResponseDTO : User
    {
        public new string Password { set => base.Password = value; }
        public override ICollection<Order> Orders { set => base.Orders = value; }
    }
}
