﻿using System.ComponentModel.DataAnnotations;

namespace Nite.API.Data.Models
{
    public class LoginDTO
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
