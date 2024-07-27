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
        string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
        string ADMIN_USER_ID = Guid.NewGuid().ToString();

        string EMPLOYEE_ROLE_ID = Guid.NewGuid().ToString();
        string EMPLOYEE_USER_ID = Guid.NewGuid().ToString();

        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = ADMIN_USER_ID,
                UserName = "admin@websiteadmin.com",
                NormalizedUserName = "ADMIN@WEBSITEADMIN.COM",
                Email = "admin@websiteadmin.com",
                EmailConfirmed= true,
                PasswordHash = "AQAAAAEAACcQAAAAEI/tEodNZh5k32ypJIqfYBb453glQZtDdNsaUfK8H+3ZwOgedKOjoJNVOm1vHsg3PQ==",
                SecurityStamp = "PJT225JMNX52X76CTIHQAECWQ6OTUPLN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumberConfirmed = false,
                TwoFactorEnabled= false,
                LockoutEnabled= true,
                AccessFailedCount= 0,
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = EMPLOYEE_USER_ID,
                UserName = "employee@websiteemployee.com",
                NormalizedUserName = "EMPLOYEE@WEBSITEEMPLOYEE.COM",
                Email = "employee@websiteemployee.com",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEALKqgsJS/svrlZECuMjOBmV52/DPzF5sbccfyHNpOn6qzFRPJl9KJDdzXBvZwjWsg==",
                SecurityStamp = "MHCYXXHRGO2UODBVZFASZDAHCW5ZQ2LO",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = true,
                AccessFailedCount = 0,
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = ADMIN_ROLE_ID,
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Employee",
                NormalizedName = "EMPLOYEE",
                Id = EMPLOYEE_ROLE_ID,
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
       

           builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_ID,
                UserId = ADMIN_USER_ID
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = EMPLOYEE_ROLE_ID,
                UserId = EMPLOYEE_USER_ID
            });

            /*builder.Entity<Book>().HasData(new Book
            {
                BookId = Guid.NewGuid(),
                Author = "Henryk Sienkiewicz",
                Title = "W pustyni i w puszczy",
                Description= "Description",
                Price = 20.5,
                ImgPath = "asd"
            });

            builder.Entity<Book>().HasData(new Book
            {
                BookId = Guid.NewGuid(),
                Author = "Stanisław Wyspiański",
                Title = "Wesele",
                Description = "Description",
                Price = 30.5,
                ImgPath = "asd"
            });*/
        }
    }
}
