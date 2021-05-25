using System;
namespace Lession4
{
    public class MyMath
    {
        public static double Pi = 3.1415;
        public static long Power(int a, int n)
        {
            long result = 1;
            for(int i = 1; i<= n;i++){
                result *= a;
            }
            return result;
        }

        public static double GetAreaTriangle(double side1, double side2, double side3){
            return side1 + side2 + side3;
        }

        public double GetPrimerRectangle(double length, double width){
            return length* width;
        }
    }
}