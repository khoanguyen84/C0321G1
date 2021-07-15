using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private List<Student> Students;
        public StudentService()
        {
            Students = new List<Student>() {
                new Student()
                {
                    Id = 1,
                    Fullname = "Buu Nguyen",
                    Dob = DateTime.Parse("2000-10-10"),
                    Avatar = "/images/avatar10.jpg",
                    DepartmentId= 1,
                    Department = new Department()
                                {
                                    DepartmentId= 1,
                                    DepartmentName = "IT"
                                }
                },
                new Student()
                {
                    Id = 2,
                    Fullname = "Nam Thu",
                    Dob = DateTime.Parse("2000-10-10"),
                    Avatar = "/images/avatar11.jpg",
                    DepartmentId= 1,
                    Department = new Department()
                                {
                                    DepartmentId= 1,
                                    DepartmentName = "IT"
                                }
                },
                new Student()
                {
                    Id = 3,
                    Fullname = "Nam Ngoc",
                    Dob = DateTime.Parse("2000-10-10"),
                    Avatar = "/images/avatar12.jpg",
                    DepartmentId= 1,
                    Department = new Department()
                                {
                                    DepartmentId= 1,
                                    DepartmentName = "IT"
                                }
                }
            };
        }

        public Student Create(Student student)
        {
            student.Id = Students.Max(s => s.Id) + 1;
            Students.Add(student);
            return student;
        }

        public Student GetStudent(int studentId)
        {
            return Students.FirstOrDefault(s => s.Id == studentId);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}
