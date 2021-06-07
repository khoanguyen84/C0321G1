using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lession10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();


            Queue<Student> students = new Queue<Student>();
            students.Enqueue(new Student());
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("KHoa");

            List<int> ints = new List<int>();

            List<List<int>> matrix = new List<List<int>> {
                                            new List<int>() { 1, 2, 4 },
                                            new List<int>() { 1, 2, 4 },
                                            new List<int>() { 1, 2, 4 },
                                            new List<int>() { 1, 2, 4 }
                                        };

            LinkedList<Student> stds = new LinkedList<Student>();
            Dictionary<int, Student> stds2 = new Dictionary<int, Student>();

            Student s = new Student();
            stds2.Add(s.StudentId, s);
            stds2.ContainsValue(s);
        }
    }

    class Student
    {
        public int StudentId { get; set; }
        public string Fullname { get; set; }
        public bool Gender { get; set; }
    }
}

