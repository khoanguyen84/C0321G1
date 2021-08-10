using Microsoft.EntityFrameworkCore;
using PNBS.Contexts;
using PNBS.Entities;
using PNBS.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNBS.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext context;

        public StudentService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Student> Create(CreateStudent student)
        {
            try
            {
                var newStudent = new Student()
                {
                    Dob = student.Dob,
                    Email = student.Email,
                    Fullname = student.Fullname,
                    Gender = student.Gender,
                    GradeId = student.GradeId
                };
                context.Add(newStudent);
                var studentId = await context.SaveChangesAsync();
                newStudent.StudentId = studentId;
                return newStudent;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Student>> Gets()
        {
            return await context.Students.Include(s => s.Grade).ToListAsync();
        }
    }
}
