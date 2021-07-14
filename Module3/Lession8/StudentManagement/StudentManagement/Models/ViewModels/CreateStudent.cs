using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models.ViewModels
{
    public class CreateStudent
    {
        [Required(ErrorMessage = "The Fullname is mandatory!")]
        [StringLength(maximumLength: 50, MinimumLength = 10)]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "The Dob is mandatory!")]
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public IFormFile Avatar { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
    }
}
