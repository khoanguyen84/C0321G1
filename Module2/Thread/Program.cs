using System;
using System.Threading;
namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create new thread .............\n");
            Thread newThead = new Thread(WriteB);
            newThead.Start();
            Console.WriteLine("Call Write(-) in main Thread .............\n");
            for(int i = 1; i<=10; i++){
                Console.WriteLine("-");
            }
            Console.WriteLine("Main thread finished\n");
            Console.Read();
        }

        public static void  WriteB(){
            for(int i = 1; i<=10; i++){
                Console.WriteLine("B");
            }
            Thread.Sleep(100);
        }
    }
}
