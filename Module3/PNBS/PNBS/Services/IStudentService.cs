using PNBS.Entities;
using PNBS.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNBS.Services
{
    public interface IStudentService
    {
        Task<Student> Create(CreateStudent student);
        Task<List<Student>> Gets();
    }
}
