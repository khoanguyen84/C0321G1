using System;
using System.Collections.Generic;
namespace SchoolManagement
{
    class Student
    {
        public int MaHS { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string Lop { get; set; }
        public List<Course> MonHoc { get; set; }
        public decimal DTB => CalculatorAverageScores();
        public string XepLoai => Rank();

        private decimal CalculatorAverageScores()
        {
            decimal total = 0;
            foreach (Course course in MonHoc)
            {
                if (course.TenMon == "Toán")
                {
                    total += course.Diem * 2;
                }
                total += course.Diem;
            }
            return total / 4;
        }

        private string Rank()
        {
            string rank = "Yeu";
            if (DTB >= 9 && DTB <= 10)
                rank = "Xuat sac";
            else if (DTB >= 8)
                rank = "Gioi";
            else if (DTB >= 7)
                rank = "Kha";
            else if (DTB >= 5)
                rank = "TB";
            return rank;
        }
    }
}