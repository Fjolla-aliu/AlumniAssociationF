using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AlumniAssociationF.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Emri { get; set; }    
        public string Mbiemri { get; set; }
        public DateTime DataLindjes { get; set; }
        public string NumriTelefonit { get; set; }

        /* 1- simple user, 2- registered, 3-ceo user, 4-*/

        public int Role { get; set; }

        

    }
}
