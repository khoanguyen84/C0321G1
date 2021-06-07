using System;
namespace ZooManagement
{
    class Cat : Animal
    {
        public Cat() : base()
        {
            
        }

        public Cat(string name) : base(name)
        {
            
        }

        public Cat(string name, int age) : base(name, age)
        {
            
        }

        public Cat(string name, int age, string desc) : base(name, age, desc)
        {
            
        }
        public override string Speak()
        {
            return "meomeomeo";
        }
    }
}