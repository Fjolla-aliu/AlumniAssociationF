using System.ComponentModel.DataAnnotations;

namespace AlumniAssociationF.Models
{
    public class Faq
    {
        public int Id { get; set; }

        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer { get; set; }
    }
}
