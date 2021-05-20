using System;
namespace Lession2
{
    class MethodDemo
    {
        public static void Main(string[] args)
        {
            // Console.Write("Enter number 1:");
            // int n1 = int.Parse(Console.ReadLine());
            // Console.Write("Enter number 2:");
            // int n2 = int.Parse(Console.ReadLine());
            // Console.WriteLine($"{n1} + {n2} = {Sum(n1,n2)}");
            // int n1 = 5;
            // int n2 = 7;
            // Console.WriteLine($"Outside Swap Func: {n1} - {n2}");
            // Swap(ref n1,ref n2, out int temp);
            // Console.WriteLine($"Outside Swap Func: {n1} - {n2}, temp = {temp}");

            // int position;
            // Console.WriteLine($"Total value divide by 5 = {SumValues(out int position)}, at position: {position}");
            // int[] array = GenerateArray(10);
            // Console.WriteLine(string.Join(",", array));
            // object s1 = "CodeGym";
            // object s2 = new string("CodeGym");
            // Console.WriteLine(s1 == s2);
            // Console.WriteLine(s1.Equals(s2));
            // OverLoading ~ Tải bội
        }

        public static int NumberDouble(int n){
            return n + n;
        }

        public static float Sum(float n1, float n2){
            return n1 + n2;
        }
        public static int Sum(int n){
            return n + n;
        }
        public static int Sum(int n1, int n2)
        {
            int total = n1 + n2;
            return total;
        }

        public static void Swap(ref int n1,ref int n2, out int value)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine($"Inside Swap Func: {n1} - {n2}");
            value = temp;
        }

        public static int SumValues(out int pos)
        {
            int total = 0;
            int i= 1;
            for(i=1; i<=100;i++){
                if(i%5 == 0){
                   
                    break;
                }
                total += i; 
            }
            pos = i;
            return total;
        }

        public static int[] GenerateArray(int size, int min = 10,  int max = 80)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for(int i=0;i<size;i++){
                arr[i] = rnd.Next(min, max);
            }
            return arr;
        }
    }
}