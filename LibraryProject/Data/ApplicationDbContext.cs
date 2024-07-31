using LibraryProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUserRole<Guid>>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            var ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            var ADMIN_USER_ID = Guid.NewGuid().ToString();

            var ADMIN_ROLE = new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = ADMIN_ROLE_ID,
            };

            var ADMIN_USER = new IdentityUser
            {
                Id = ADMIN_USER_ID.ToString(),
                UserName = "admin@websiteadmin.com",
                NormalizedUserName = "ADMIN@WEBSITEADMIN.COM",
                Email = "admin@websiteadmin.com",
                EmailConfirmed = true,
                SecurityStamp = string.Empty,
            };

            var hasher = new PasswordHasher<IdentityUser>();
            ADMIN_USER.PasswordHash = hasher.HashPassword(ADMIN_USER, "admin123");

            builder.Entity<IdentityRole>().HasData(ADMIN_ROLE);
            builder.Entity<IdentityUser>().HasData(ADMIN_USER);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_USER_ID,
            });
        }
    }
}
