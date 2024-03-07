using EsemkaBakery.Database;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace EsemkaBakery.DTOs.Request
{
    public class RegisterRequestDTO : User
    {
        [Required]
        public string PasswordConfirmation { get; set; } = string.Empty;
        [JsonIgnore]
        public new int UserID { get => base.UserID; set => base.UserID = value; }
        [EmailAddress]
        public new string Email { get; set; } = string.Empty;
        [JsonIgnore]
        public override ICollection<Order> Orders { set => base.Orders = value; }
    }
}
