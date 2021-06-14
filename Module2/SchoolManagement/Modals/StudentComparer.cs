using System.Collections.Generic;

namespace SchoolManagement
{
    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return (int)(y.DTB - x.DTB);
        }
    }
}