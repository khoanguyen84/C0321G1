namespace Lession5
{
    public abstract class Animal
    {
        public string Name;
        public Animal(string name){
            this.Name = name;
        }
        public virtual string Info(){
            return $"name:{this.Name}";
        }
        public abstract string Speak();
        public abstract string Move();
    }

    public class Dog : Animal
    {
        public int Legs;
        public Dog(string name, int legs) : base(name){
            this.Legs = legs;
        }

        public override string ToString()
        {
            return $"Dog name: {this.Name}, legs: {this.Legs}";
        }

        public override string Info()
        {
            return $"Dog: {base.Info()}";
        }
        public override string Speak()
        {
            return "gogo";
        }

        public override string Move()
        {
            return "walking by 4 legs";
        }
    }

    public class Betze : Dog{
        public Betze(string name, int legs) : base(name, legs){

        }

        public override string Info(){
            return "a";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    public class Duck : Animal
    {
        public int Legs;
        public Duck(string name, int legs) : base(name){
            this.Legs = legs;
        }
        public override string ToString()
        {
            return $"Duck name: {this.Name}, legs: {this.Legs}";
        }
        public override string Speak()
        {
            return "Capcap";
        }

        public override string Move()
        {
            return "walking by 2 legs";
        }
    }
}