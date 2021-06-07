using System;
namespace ZooManagement
{
    class Tiger : Animal
    {
        public Tiger() : base()
        {
            
        }

        public Tiger(string name) : base(name)
        {
            
        }

        public Tiger(string name, int age) : base(name, age)
        {
            
        }

        public Tiger(string name, int age, string desc) : base(name, age, desc)
        {
            
        }
        public override string Speak()
        {
            return "Cop cop";
        }
    }
}