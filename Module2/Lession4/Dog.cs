namespace Lession4
{
    public class Dog : Animal
    {
        public int legs;
        public Dog(string name,int age, int legs) : base(name, age)
        {
            this.legs = legs;
        }

        // public override string Info(){
        //     return $"{base.Info()}, legs : {this.legs}";
        // }
        public override string ToString(){
            return $"info:{this.Name}, {this.Age}, legs : {this.legs}";
        }
    }
}