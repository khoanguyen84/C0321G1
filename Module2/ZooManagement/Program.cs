using System;

namespace ZooManagement
{
    class Program
    {
        private static Zoo zooService = new Zoo();
        static void Main(string[] args)
        {
            Cage cage1 = new Cage();
            cage1.CageNumber = 1;
            Animal tiger1 = new Tiger("Cop Giay", 100, "Ko ai so het");
            cage1.AddAnimal(tiger1);
            Animal dog1 = new Dog("Bum", 10, "Khong rang mo");
            cage1.AddAnimal(dog1);

            Cage cage2 = new Cage();
            cage2.CageNumber = 2;
            Animal cat1 = new Cat("Tom", 10, "Carton Network");
            cage2.AddAnimal(cat1);
            Animal dog2 = new Dog("Socubido", 1, "Kha he huoc");
            cage2.AddAnimal(dog2);
            
            zooService.AddCage(cage1);
            zooService.AddCage(cage2);

            zooService.ShowZooInfo();

        }
    }
}
