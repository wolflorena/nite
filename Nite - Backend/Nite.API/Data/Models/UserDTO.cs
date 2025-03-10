﻿namespace Nite.API.Data.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Gender { get; set; }
        public string? Birthdate { get; set; }
        public bool IsAdmin { get; set; }
    }
}
