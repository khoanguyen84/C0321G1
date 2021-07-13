using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Fullname is mandatory!")]
        [StringLength(maximumLength:50, MinimumLength = 10)]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "The Dob is mandatory!")]
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Avatar can not empty")]
        public string Avatar { get; set; }
    }
}
