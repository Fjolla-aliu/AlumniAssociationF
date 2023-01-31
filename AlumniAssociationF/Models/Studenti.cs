using System.ComponentModel.DataAnnotations;

namespace AlumniAssociationF.Models
{
    public class Studenti
    {
       
            public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
       
             [Required]
             [EmailAddress]
            public string? Email { get; set; }
        [Required]
        public string? Contact { get; set; }
            public string? City { get; set; }
            public string? State { get; set; }
        [Required]
        public string? University { get; set; }
       
        [Required]
        [Display(Name = "Average grade")]
            public double AvGrade { get; set; }
            public string? Gender { get; set; }
            public string? JobStatus { get; set; }



        
    }
}
