using System;
using System.Collections;
using System.Collections.Generic;
namespace MyGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            MyList<int> myList = new MyList<int>();
            MyList<Student> students = new MyList<Student>();
            myList.Add(55);
            // Console.WriteLine(myList[0]);

            myList.AddRange(new int[] {1,2,3,4,5,6,7, 8});

            // for(int i=0; i < myList.Count; i++){
            //     Console.WriteLine(myList[i]);
            // }
            // foreach(int item in myList){
            //     Console.WriteLine(item);
            // }
            Console.WriteLine(myList.Capacity);
            myList.Remove(4);
            Console.WriteLine(myList.Capacity);
        }
    }

    

    class Student
    {
        
    }
}
