using System.ComponentModel.DataAnnotations;

namespace AlumniAssociationF.Models
{
    public class Partners
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Institution { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Contact { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
    }
}
