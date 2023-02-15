using System.ComponentModel.DataAnnotations;

namespace AlumniAssociationF.Models
{
    public class Program
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string? Description { get; set; }

        public ICollection<Eventet> Events { get; set; }
    }
}
