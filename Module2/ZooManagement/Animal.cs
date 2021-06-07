using System;
namespace ZooManagement
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public Animal()
        {
            
        }

        public Animal(string name)
        {
            Name = name;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Animal(string name, int age, string desc)
        {
            Name = name;
            Age = age;
            Description = desc;
        }

        public string ViewInfo(){
            return$"{this.Name}\t\t{this.Age}\t\t\t{this.Description}";
        }

        public abstract string Speak();
    }
}