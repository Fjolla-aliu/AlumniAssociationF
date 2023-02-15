using System.ComponentModel.DataAnnotations;

namespace AlumniAssociationF.Models
{
    public class Eventet
    {
        public int Id { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime Deadline { get; set; }

        public int ProgramId { get; set; }
        public Program Program { get; set; }
    }
}
