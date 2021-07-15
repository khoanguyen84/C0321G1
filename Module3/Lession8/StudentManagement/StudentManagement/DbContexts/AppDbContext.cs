using Microsoft.EntityFrameworkCore;
using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(
                new Department()
                {
                    DepartmentId = 1,
                    DepartmentName = "IT"
                },
                new Department()
                {
                    DepartmentId = 2,
                    DepartmentName = "Ecommerce"
                },
                new Department()
                {
                    DepartmentId = 3,
                    DepartmentName = "Historical"
                });
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    Fullname = "Buu Nguyen",
                    Dob = DateTime.Parse("2000-10-10"),
                    Avatar = "/images/avatar10.jpg",
                    DepartmentId = 3
                },
                new Student()
                {
                    Id = 2,
                    Fullname = "Nam Thu",
                    Dob = DateTime.Parse("2000-10-10"),
                    Avatar = "/images/avatar11.jpg",
                    DepartmentId = 2
                },
                new Student()
                {
                    Id = 3,
                    Fullname = "Nam Ngoc",
                    Dob = DateTime.Parse("2000-10-10"),
                    Avatar = "/images/avatar12.jpg",
                    DepartmentId = 1
                });
        }
    }
}
