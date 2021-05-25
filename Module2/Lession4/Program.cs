using System;

namespace Lession4
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n1 = 3;
            // int n2 = 4;
            // MyMath myMath = new MyMath();
            // myMath.GetPrimerRectangle(10,25.5);

            // Console.WriteLine($"{n1} ^ {n2} = {MyMath.Power(n1,n2)}");

            // Console.WriteLine(MyMath.GetAreaTriangle(3.5, 4.5, 7));

            // Console.WriteLine(10*10*MyMath.Pi);

            Dog milu = new Dog("Milu", 4, 4);
            Console.WriteLine(milu.ToString());
            Cat tom = new Cat("Tome", 4, "Black");
            Console.WriteLine(tom.ToString());

            Animal a = new Animal("Animal", 4);
            Console.WriteLine(a.ToString());
        }
    }
}
