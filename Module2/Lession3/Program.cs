using System;
using Lession33;

namespace Lession3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Student thanh = new Student();
            // thanh.Fullname = "Thanh Ho";
            // thanh.SetAge(18);
            // var age = thanh.GetAge();
            // thanh.Email = "thanh.ho@codegym.vn";
            // thanh.Pin = "123456789";
            // Console.WriteLine($"{thanh.Greeting()}, Email: {thanh.Email}, PinCode: {thanh.Pin}");

            // Student hung = new Student("Hung Tran", "hung.tran@codegym.vn");
            // Console.WriteLine($"{hung.Greeting()}, Email: {hung.Email}");

            // Student duy = new Student(fullname: "Duy Le",email: "duy.le@codegy.vn", age: 18, pin: "123456789");
            // Student buu = new Student("Buu Nguyen",18, "buu.nguyen@codegym.vn","123456789");

            Student Long = new Student();

            Human khoa = new Human();
            khoa.Fullname = "Khoa";

            Human.Male nam = new Human.Male();
            nam.Hobbie = "Football";
        }
    }

    public class Human
    {
        public string Fullname {get;set;}
        public class Male
        {
            public string Hobbie {get;set;}

        }

    }
}
