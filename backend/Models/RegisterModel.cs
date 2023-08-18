using System;
using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}

