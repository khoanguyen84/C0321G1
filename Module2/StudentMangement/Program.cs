using System;

namespace StudentMangement
{
    class Program
    {
        const int min = 1;
        const int max = 5;
        const int exitCode = 5;
        public static int id = 1;
        public static Student[] Students = new Student[0];
        static void Main(string[] args)
        {
            Process();
        }
        public static void BuildMenu(out int option)
        {
            do
            {
                Console.WriteLine("----Calculator Menu----");
                Console.WriteLine("1. Create new student");
                Console.WriteLine("2. Input scores");
                Console.WriteLine("3. Show student list");
                Console.WriteLine("4. Search");
                Console.WriteLine("5. Exit");
                Console.Write($"Please choice a number ({min},{max}):");
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    option = 0;
                }
            }
            while (option < min || option > max);
        }

        public static void Process()
        {
            var selected = 0;
            do
            {
                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case 1:
                        {
                            CreatNewStudent();
                            break;
                        }
                    case 2:
                        {
                            InputScores();
                            break;
                        }
                    case 3:
                        {
                            Show();
                            break;
                        }
                    case 4:
                        {
                            Search();
                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }

            }
            while (selected != exitCode);
        }

        public static void CreatNewStudent()
        {
            Console.Write("Enter fullname: ");
            string fullname = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter gender: ");
            bool gender = bool.Parse(Console.ReadLine());
            Student student = new Student(id, fullname, age, gender);
            id++;

            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;

            Show();
        }

        public static void Show()
        {
            Console.Write($"#Id\tFullname\tge\tGender\tMath\tPhysics\tChemistry\tAveScore\tRank\n");
            foreach (Student student in Students)
            {
                Console.Write(student.Print());
            }
        }

        public static void InputScores()
        {
            Console.Write("Enter StudentId: ");
            int studentId = int.Parse(Console.ReadLine());

            Student student = Find(studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found!");
            }
            else
            {
                Console.Write("Enter Math Score: ");
                double math = double.Parse(Console.ReadLine());
                Console.Write("Enter Physics Score: ");
                double physics = double.Parse(Console.ReadLine());
                Console.Write("Enter Chemistry Score: ");
                double chemistry = double.Parse(Console.ReadLine());
                student.InputScores(math, physics, chemistry);

                Show();
            }

        }

        public static void Search(){
            Console.Write("Enter keyword: ");
            string keyword = Console.ReadLine();

            Console.Write($"#Id\tFullname\tge\tGender\tMath\tPhysics\tChemistry\tAveScore\tRank\n");
            foreach(Student student in Students){
                if(student.Fullname.ToLower().Contains(keyword)){
                    Console.Write(student.Print());
                }
            }
        }

        private static Student Find(int studentId)
        {
            foreach (Student student in Students)
            {
                if (student.StudentId == studentId)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
