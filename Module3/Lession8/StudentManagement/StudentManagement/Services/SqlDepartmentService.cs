using StudentManagement.DbContexts;
using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class SqlDepartmentService : IDepartmentService
    {
        private readonly AppDbContext context;

        public SqlDepartmentService(AppDbContext context)
        {
            this.context = context;
        }
        public List<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }
    }
}
