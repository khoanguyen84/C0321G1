using System;

namespace Menu
{
    class Program
    {
        const int min = 1;
        const int max = 5;
        const int exitCode = 5;
        static void Main(string[] args)
        {
            Process();
        }

        public static void BuildMenu(out int option)
        {
            do
            {
                Console.WriteLine("----Calculator Menu----");
                Console.WriteLine("1. Add Operator");
                Console.WriteLine("2. Subtract Operator");
                Console.WriteLine("3. Multiple Operator");
                Console.WriteLine("4. Divide Operator");
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
                switch(selected)
                {
                    case 1:{
                        Console.WriteLine("You are selected 1");
                        break;
                    }
                    case 2:{
                        Console.WriteLine("You are selected 2");
                        break;
                    }
                    case 3:{
                        Console.WriteLine("You are selected 3");
                        break;
                    }
                    case 4:{
                        Console.WriteLine("You are selected 4");
                        break;
                    }
                    case 5:{
                        Environment.Exit(0);
                        break;
                    }
                }
                
            }
            while (selected != exitCode);
        }
    }
}
