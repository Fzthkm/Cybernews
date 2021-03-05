using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Киберфорум.Models;

namespace Киберфорум.Models
{
    public class CyberforumContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<FileModel> FileModels { get; set; }
        public CyberforumContext(DbContextOptions<CyberforumContext> options) 
            : base(options) 
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminEmail = "sin97ch@gmail.com";
            string adminName = "Sin97";
            string adminPassword = "123456";

            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            User adminUser = new User { Id = 1, _Username = adminEmail, _Password = adminPassword,_Name = adminName, RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Киберфорум.Models.Review> Review { get; set; }
    }
}
