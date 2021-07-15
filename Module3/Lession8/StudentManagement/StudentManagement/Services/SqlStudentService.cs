using Microsoft.EntityFrameworkCore;
using StudentManagement.DbContexts;
using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class SqlStudentService : IStudentService
    {
        private readonly AppDbContext context;

        public SqlStudentService(AppDbContext context)
        {
            this.context = context;
        }
        public Student Create(Student student)
        {
            context.Add(student);
            var StudentId = context.SaveChanges();

            return new Student() { 
                Avatar = student.Avatar,
                DepartmentId = student.DepartmentId,
                Dob = student.Dob,
                Fullname = student.Fullname,
                Id = StudentId
            };
        }

        public Student GetStudent(int studentId)
        {
            return context.Students.Include(d => d.Department).ToList().SingleOrDefault(s => s.Id == studentId);
        }

        public List<Student> GetStudents()
        {
            return context.Students.Include(d => d.Department).ToList();
        }
    }
}
