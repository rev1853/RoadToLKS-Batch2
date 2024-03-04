using System.ComponentModel.DataAnnotations;

namespace WebApi_01.DTOs
{
    public class StoreCategoryDTO
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
