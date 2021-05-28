using System;

namespace Menu
{
    public class Program
    {
        const int min = 1;
        const int max = 5;
        const int exitCode = 5;
        const int addOperand = 1;
        const int subtractOperand = 2;
        const int multipleOperand = 3;
        const int divideOperand = 4;
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
                    case (int)Helper.Operand.Add:{
                        Calculator((int)Helper.Operand.Add);
                        break;
                    }
                    case subtractOperand:{
                        Calculator((int)Helper.Operand.Substract);
                        break;
                    }
                    case Helper.Operand2.Multiple:{
                        Calculator((int)Helper.Operand.Multiple);
                        break;
                    }
                    case divideOperand:{
                        Calculator((int)Helper.Operand.Divide);
                        break;
                    }
                    case (int)Helper.Operand.Exits:{
                        Environment.Exit(0);
                        break;
                    }
                }
                
            }
            while (selected != exitCode);
        }

        public static void Calculator(int operand){
            Console.Write("Enter number 1:");
            float number1 = float.Parse(Console.ReadLine());
            Console.Write("Enter number 2:");
            float number2 = float.Parse(Console.ReadLine());
            if(operand == (int)Helper.Operand.Add){
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            }
            if(operand == (int)Helper.Operand.Substract){
                Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            }
            if(operand == (int)Helper.Operand.Multiple){
                Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
            }
            if(operand == (int)Helper.Operand.Divide){
                Console.WriteLine(number2 == 0.0 ? $"Error divide by zero!" : $"{number1} : {number2} = {number1 / number2}");
                // if(number2 == 0.0){
                //     Console.WriteLine($"Error divide by zero!");    
                // }
                // else
                // {
                //     Console.WriteLine($"{number1} : {number2} = {number1 / number2}");
                // }
            }
        }
    }

    
}
