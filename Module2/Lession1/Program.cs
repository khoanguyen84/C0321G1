using System;
using System.Text;
namespace Lession1
{
    class Program
    {
        public static void Main(string[] agrs){
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            var total = 10;
            byte sum = 10;
            dynamic count = 5;
            string path = @"C:\CodeGym\Class\C0321G1\Module2\Lession1";
            
            // Console.Write($"Total:{total + 20}\n");
            // Console.WriteLine($"Sum: {sum},\t count: {count}");

            // if(total == sum){
            //     Console.WriteLine("Total equals sum");
            // }
            // byte i =0;
            // for(; i< 10; ){
            //     Console.WriteLine($"{i+1}");
            //     i++;
            // }
            // byte j = 0;
            // while(j< 10){
            //     j++;
            //     Console.WriteLine($"{j}");
            // }
            // byte i=0;
            // do{
            //     i++;
            //     Console.WriteLine($"{i}");       
            // }
            // while(i<10);

            byte score = 0;
            string rank = "Yếu";
            if(score >=9 && score <=10){
                rank= "Xuất Sắc";
            }
            else if(score >=8){
                rank = "Giỏi";
            }
            else if(score >= 7){
                rank = "Khá";
            }
            else if(score >= 5){
                rank  = "Trung Bình";
            }

            Console.WriteLine($"{rank}");
        }
    }
}