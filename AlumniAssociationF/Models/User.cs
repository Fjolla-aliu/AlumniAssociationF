using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AlumniAssociationF.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Username { get; set; }    
       
        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }
        public string RefreshToken { get; set; }    
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }



    }
}
