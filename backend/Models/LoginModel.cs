using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{

    public class LoginModel
    {
        [Required]
        public string Username { get; set; } = string.Empty; // Varsayılan değer ataması

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty; // Varsayılan değer ataması

        public bool RememberMe { get; set; }
    }

}