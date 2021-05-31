using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Demo
{
    public class MyMath
    {
        public int[] Int_Arr = new int[0];
        public int Additional(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Push(int value)
        {
            Array.Resize(ref Int_Arr, Int_Arr.Length + 1);
            Int_Arr[Int_Arr.Length - 1] = value;
            return Int_Arr.Length;
        }
    }
}
