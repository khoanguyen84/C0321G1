using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PNBS.Entities
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [Required]
        [MaxLength(40)]
        public string GradeName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
