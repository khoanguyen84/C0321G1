using System;

namespace Lession5
{
    class Program : Object
    {
        static void Main(string[] args)
        {
            // var n = "5";
            // int n2 = int.Parse(n);
            // int n3 = (int)n;
            // Animal animal1 = new Animal("fish")

            Animal[] zoo = new Animal[2] {
                                            new Dog("Bum", 4),
                                            new Duck("Donan", 2)
                                        };
            Console.WriteLine("Zoo information");
            foreach(Animal animal in zoo){
                if(animal is Dog){
                    Console.WriteLine(((Dog)animal).ToString());
                    // Console.WriteLine(animal.ToString());
                }
                if(animal is Duck)
                {
                    Console.WriteLine(((Duck)animal).ToString());
                    // Console.WriteLine(animal.ToString());
                }
            }
        }
    }
}
