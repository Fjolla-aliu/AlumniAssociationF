﻿using AlumniAssociationF.Models;
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

    }
}