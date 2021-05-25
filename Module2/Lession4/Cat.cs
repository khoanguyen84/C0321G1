namespace Lession4
{
    class Cat : Animal
    {
        public string color;
        public Cat(string name, int age, string color) : base(name, age)
        {
            this.color = color;
        }

        public override string ToString(){
            return $"{base.ToString()}, color : {this.color}";
        }
    }
}