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

            var EMPLOYEE_ROLE_ID = Guid.NewGuid().ToString();
            var EMPLOYEE_USER_ID = Guid.NewGuid().ToString();

            var ROLES = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Id = ADMIN_ROLE_ID,
                },

                new IdentityRole
                {
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                    Id = EMPLOYEE_ROLE_ID,
                }
            };

            var CORE_USERS = new List<IdentityUser>
            {
                new IdentityUser
                {
                    Id = ADMIN_USER_ID.ToString(),
                    UserName = "admin@websiteadmin.com",
                    NormalizedUserName = "ADMIN@WEBSITEADMIN.COM",
                    Email = "admin@websiteadmin.com",
                    EmailConfirmed = true,
                    SecurityStamp = string.Empty,
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin123"),
                },
                new IdentityUser
                {
                    Id = EMPLOYEE_USER_ID.ToString(),
                    UserName = "employee@websiteempl.com",
                    NormalizedUserName = "EMPLOYEE@WEBSITEEMPL.COM",
                    Email = "employee@websiteempl.com",
                    EmailConfirmed = true,
                    SecurityStamp = string.Empty,
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "empl123"),
                }
            };
     
            builder.Entity<IdentityRole>().HasData(ROLES);
            builder.Entity<IdentityUser>().HasData(CORE_USERS);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_USER_ID,
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = EMPLOYEE_ROLE_ID,
                UserId = EMPLOYEE_USER_ID,
            });
        }
    }
}
