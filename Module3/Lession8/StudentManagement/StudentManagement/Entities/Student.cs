using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentManagement.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Fullname is mandatory!")]
        [StringLength(maximumLength:50, MinimumLength = 10)]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "The Dob is mandatory!")]
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Avatar can not empty")]
        [MaxLength(500)]
        public string Avatar { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
