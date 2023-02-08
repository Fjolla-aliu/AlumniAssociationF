using AlumniAssociationF.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlumniAssociationF.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Studenti> Students { get; set; }

        public DbSet<Events> Events { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Faq> FAQs { get; set; }
        public DbSet<AlumniAssociationF.Models.ViewUser> ViewUser { get; set; }
        public DbSet<AlumniAssociationF.Models.Center> Center { get; set; }
      
    }
}