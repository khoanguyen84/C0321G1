using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public DateTime Dob { get; set; }
        public string Avatar { get; set; }
    }
}
