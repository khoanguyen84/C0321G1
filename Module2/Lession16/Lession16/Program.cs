using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lession16
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\CodeGym\Class\C0321G1\Module2\Lession16\Lession16\Data\";
            string fileName = "data.json";
            string student_filename = "student.json";
            string data = "";
            using (StreamReader sr = File.OpenText(Path.Combine(path, fileName)))
            {
                data = sr.ReadToEnd();

            }
            var result = JsonConvert.DeserializeObject<Result>(data);
            foreach(List<int> items in result.matrix)
            {
                foreach(int item in items)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

            foreach(Student std in result.students)
            {
                Console.WriteLine(std.ToString());
            }

            List<StudentRes> studentRes = new List<StudentRes>();
            foreach(Student std in result.students)
            {
                studentRes.Add(new StudentRes() {
                    Age = std.Age,
                    AveScore = std.CalsAveScore(),
                    Fullname = std.Fullname,
                    StudentId = std.StudentId
                });
            }
            Response response = new Response();
            response.students = studentRes;
            using (StreamWriter sw = File.CreateText(Path.Combine(path, student_filename)))
            {
                sw.WriteLine(JsonConvert.SerializeObject(response));
            }
        }
    }
    class Result
    {
        public List<List<int>> matrix;
        public Student[] students;
    }

    class Student
    {
        public int StudentId { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public Score[] scores { get; set; }

        public override string ToString()
        {
            return $"{StudentId}\t\t{Fullname}\t\t{Age}\t\t{CalsAveScore()}";
        }

        public decimal CalsAveScore()
        {
            decimal total = 0;
            foreach(Score score in scores)
            {
                total += score.score;
            }
            return total / scores.Length;
        }
    }

    class Score
    {
        public string name { get; set; }
        public decimal score { get; set; }
    }

    class StudentRes
    {
        public int StudentId { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public decimal AveScore { get; set; }
    }

    class Response
    {
        public List<StudentRes> students { get; set; }
    }
}
