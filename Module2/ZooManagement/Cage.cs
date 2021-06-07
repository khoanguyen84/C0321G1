using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ZooManagement
{
    class Cage
    {
        public int CageNumber { get; set; }
        // private ArrayList AnimalList = new ArrayList();
        private List<Animal> Animals = new List<Animal>();

        public void AddAnimal(Animal animal){
            // AnimalList.Add(animal);
            Animals.Add(animal);
        }

        public void RemoveAnimal(string name){
            // Animal foundAnimal = null;
            // foreach(Animal animal in AnimalList){
            //     if(animal.Name == name){
            //         foundAnimal = animal;
            //         break;
            //     }
            // }

            Animal b = null;
            foreach(Animal a in Animals){
                if(a.Name.Contains("ab") && a.Age > 5){
                    b = a;
                    break;
                }
            }
            Animal al = Animals.FirstOrDefault(a => a.Name.Contains("ab") && a.Age >5);

            List<Animal> list = new List<Animal>();
            foreach(Animal a in Animals){
                if(a.Name.Contains("ab") && a.Age > 5){
                    list.Add(a);
                }
            }
            List<Animal> als = Animals.Where(a => a.Name.Contains("ab") && a.Age >5).ToList();





            Animal foundAnimal = Animals.FirstOrDefault(e => e.Name == name);

            

            

            if(foundAnimal != null){
                Animals.Remove(foundAnimal);
            }
        }

        public void ShowCageInfo(){
            foreach(Animal animal in Animals){
                Console.WriteLine($"{animal.ViewInfo()}, speak: {animal.Speak()}");
            }
        }
    }
}
