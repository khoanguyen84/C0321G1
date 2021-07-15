using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudent(int studentId);
        Student Create(Student student);
    }
}
