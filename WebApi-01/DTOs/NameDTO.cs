using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace WebApi_01.DTOs
{
    public class NameDTO
    {
        [Required]
        public string Name { get; set; }

        [Range(1, int.MaxValue)]
        public int Age { get; set; }
    }
}
