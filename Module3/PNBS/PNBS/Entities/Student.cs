using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PNBS.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(40)]
        public string Fullname { get; set; }
        public bool Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
