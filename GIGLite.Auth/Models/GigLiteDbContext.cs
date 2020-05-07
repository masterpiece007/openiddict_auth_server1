using System;
using GIGLite.Auth.Models.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GIGLite.Auth.Models
{
    public partial class MyProjectDbContext : IdentityDbContext<ApplicationUser>
    {
      
        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        {
            //Database.SetInitializer<MyProjectDbContext>(new CreateDatabaseIfNotExists<MyProjectDbContext>());

            //this.Database.Migrate();

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ApplicationUser> AspnetUsers { get; set; }

    }
}
