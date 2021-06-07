using System;
namespace ZooManagement
{
    class Dog : Animal
    {
        public Dog() : base()
        {
            
        }

        public Dog(string name) : base(name)
        {
            
        }

        public Dog(string name, int age) : base(name, age)
        {
            
        }

        public Dog(string name, int age, string desc) : base(name, age, desc)
        {
            
        }
        public override string Speak()
        {
            return "gogogogo";
        }
    }
}