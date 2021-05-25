using System;

namespace Lession4
{
    public class Animal : Object
    {
        private string name;
        private int age;

        protected string Name { get => name; set => name = value; }
        protected int Age {get => age; set => age = value;}

        public Animal(string name, int age){
            this.name = name;
            this.age = age;
        }

        public override string ToString(){
            return $"name: {this.Name}, age: {this.Age}";
        }
        // public virtual string Info(){
            
        // }
    }
}