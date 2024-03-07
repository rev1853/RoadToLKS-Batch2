﻿using System.ComponentModel.DataAnnotations;

namespace EsemkaBakery.DTOs.Request
{
    public class LoginRequestDTO
    {
        [Required(ErrorMessage = "Username or Email is required")]
        public string UsernameOrEmail { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = string.Empty;
    }
}
