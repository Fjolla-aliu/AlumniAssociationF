using System.ComponentModel.DataAnnotations;

namespace AlumniAssociationF.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string? Description { get; set; }
    }
}
