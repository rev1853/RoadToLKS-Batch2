using EsemkaBakery.Database;
using System.Text.Json.Serialization;

namespace EsemkaBakery.DTOs.Response
{
    public class PromoCodeResponseDTO : PromoCode
    {
        public new string Code { set => base.Code = value; }
        public new DateTime ValidUntil { set => base.ValidUntil = value; }
        [JsonIgnore]
        public override ICollection<Order> Orders { set => base.Orders = value; }
    }
}
