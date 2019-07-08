using CommonLibrary;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
               : base(GetOptions())
        {
        }

        private static DbContextOptions GetOptions()
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), SYS_DATA.DB_Connection).Options;
        }

        public virtual DbSet<Student> Students { get; set; }
    }
}
