using CvProject.Entity;
using CvProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CvProject.Context
{
    public class CvContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KURSAD\\SQLEXPRESS;database=CvDbNew;integrated security=true;");
        }
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; } 
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Communication> Communications { get; set; }
        public virtual DbSet<Education> Educations { get; set; } 
        public virtual DbSet<Experience> Experiences { get; set; } 
        public virtual DbSet<Hobby> Hobbies { get; set; } 
        public virtual DbSet<Talent> Talents { get; set; }
        public virtual DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
