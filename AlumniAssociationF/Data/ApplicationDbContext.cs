using AlumniAssociationF.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AlumniAssociationF.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Studenti> Students { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AlumniAssociationF.Models.Program> Programs { get; set; }
        public DbSet<AlumniAssociationF.Models.Eventet> Eventet { get; set; }
        public DbSet<Faq> FAQs { get; set; }
        public DbSet<AlumniAssociationF.Models.ViewUser> ViewUser { get; set; }
        public DbSet<AlumniAssociationF.Models.About> About { get; set; }
        public DbSet<AlumniAssociationF.Models.Center> Center { get; set; }
        public DbSet<AlumniAssociationF.Models.Team> Team { get; set; }
        public DbSet<AlumniAssociationF.Models.OurProgram> OurProgram { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

         
            modelBuilder.Entity<Eventet>()
         .HasOne(p => p.Program)
         .WithMany(b => b.Events)
         .HasForeignKey(p => p.ProgramId);
          
         base.OnModelCreating(modelBuilder);

        }
    }
}