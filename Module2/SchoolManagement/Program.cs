using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SchoolManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        public static void Process()
        {
            var student_data = Helper<School>.ReadFile("data.json");
            student_data.Students.Sort(new StudentComparer());
            Helper<School>.WriteFile("outcome.json", student_data);
        }
    }
}
