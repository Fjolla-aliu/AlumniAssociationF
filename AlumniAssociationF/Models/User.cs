using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AlumniAssociationF.Models
{
 
    public class User : IdentityUser
    {
      
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public byte[] PasswordH { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string RefreshToken { get; set; }    
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }
        public string? VerificationToken { get; set; }
        public DateTime? VerifiedAt { get; set; }
        public string? PasswordResetToken { get; set; }
        public DateTime? ResetTokenExpires { get; set; }

        public string? Role { get; set; }

    }
}
