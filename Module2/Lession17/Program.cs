using System;
using System.Threading;

namespace Lession17
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1120 = new Thread(Thread1120);
            thread1120.Priority = ThreadPriority.Highest;
            thread1120.Start();
            for(int i = 1; i<=10; i++){
                Console.WriteLine($"{i}");
            }
            Console.WriteLine($"Thread main {Thread.CurrentThread.ManagedThreadId}");
        }

        public static void Thread1120(){
           Console.WriteLine($"Thread func {Thread.CurrentThread.ManagedThreadId}");
            for(int i = 11; i<=20; i++){
                Console.WriteLine($"{i}");
            }
        }
    }
}
