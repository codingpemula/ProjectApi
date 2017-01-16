using PJTrack.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJTrack.Data
{
    class DataContext : DbContext
    {

        public DataContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projects>().HasKey(c => c.ProjectID);
            modelBuilder.Entity<Projects>().Property(p => p.ProjectName).HasColumnType("VARCHAR").IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Projects>().Property(p => p.StartDate).IsRequired();
            modelBuilder.Entity<Projects>().Property(p => p.EndDate).IsRequired();
            modelBuilder.Entity<Projects>().Property(p => p.ProjectName).HasColumnType("VARCHAR").IsRequired().HasMaxLength(100);
        }

        public DbSet<Projects> ProjectSet { get; set; }

    }
}
