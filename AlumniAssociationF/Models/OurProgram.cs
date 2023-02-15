using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AlumniAssociationF.Models
{
   
    public class OurProgram
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string? Description { get; set; }

        public ICollection<Event> Events { get; set; }

    }
}
