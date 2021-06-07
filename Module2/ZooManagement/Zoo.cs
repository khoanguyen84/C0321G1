using System;
using System.Collections;
namespace ZooManagement
{
    class Zoo{
        private ArrayList CageList = new ArrayList();


        public void AddCage(Cage c){
            CageList.Add(c);
        }

        public void RemoveCage(int cageNumber){
            Cage foundCage = null;
            foreach(Cage cage in CageList){
                if(cage.CageNumber == cageNumber){
                    foundCage = cage;
                    break;
                }
            }
            if(foundCage != null){
                CageList.Remove(foundCage);
            }
        }

        public void ShowZooInfo(){
            Console.WriteLine("Zoo information");
            foreach(Cage cage in CageList){
                Console.WriteLine($"Cage: {cage.CageNumber}");
                cage.ShowCageInfo();
            }
        }
    }
}