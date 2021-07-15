using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class DepartmentService : IDepartmentService
    {
        private List<Department> Departments;
        public DepartmentService()
        {
            Departments = new List<Department>()
            {
                new Department()
                {
                    DepartmentId= 1,
                    DepartmentName = "IT"
                },
                new Department()
                {
                    DepartmentId= 2,
                    DepartmentName = "Ecommerce"
                },
                new Department()
                {
                    DepartmentId= 3,
                    DepartmentName = "Historical"
                }
            };
        }
        public List<Department> GetDepartments()
        {
            return Departments;
        }
    }
}
