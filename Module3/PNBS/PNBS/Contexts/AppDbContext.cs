using Microsoft.EntityFrameworkCore;
using PNBS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNBS.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedingGrade(modelBuilder);
        }

        private void SeedingGrade(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().HasData(
                new Grade()
                {
                    GradeId = 1,
                    GradeName = "C0321G1"
                },
                new Grade()
                {
                    GradeId = 2,
                    GradeName = "C0621H1"
                },
                new Grade()
                {
                    GradeId = 3,
                    GradeName = "C0621H2"
                },
                new Grade()
                {
                    GradeId = 4,
                    GradeName = "C0721K1"
                });
        }
    }
}
