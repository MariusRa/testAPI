﻿using LLMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LLMS.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<LearningLanguage> LearningLanguages { get; set; }
        public DbSet<LearningSemester> LearningSemesters { get; set; }
        public DbSet<LearningTarget> LearningTargets { get; set; }
        public DbSet<Request> Requests { get; set; }

        public string DbPath { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=DESKTOP-QJFRKQB; Initial Catalog=DBLLMS; Integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = "fd262146-b53c-47b3-afc2-6484643c68d1",
                    UserName = "Admin Akademija IT test",
                    UserEmail = "admin.test@kitm.lt",
                    UserRole = "Coordinator"
                });
        }
    }
}
