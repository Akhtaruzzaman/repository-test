using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DbContext
{
    public class WebAppContext : IdentityDbContext
    {
        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>()
            .HasIndex(u => new { u.Mobile })
            .IsUnique();
           
        }

        public DbSet<Student> Students { get; set; }
    }
}
