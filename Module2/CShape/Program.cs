using System;
using System.Text;
namespace CShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            // int number1 = 5;
            // int number2= 7;
            // Console.Write($"{number1} + {number2} = { number1 + number2}");

            // int[] array = new int[] {4,5,6,3,4,5,6,7,8};
            // for(int i=0;i < array.Length; i++){
            //     Console.WriteLine($"{array[i]}");
            // }

            Console.Write("Nhập và tên của bạn: ");
            string name = Console.ReadLine();

            Console.Write($"Tên của bạn là: {name}");
        }
    }
}
