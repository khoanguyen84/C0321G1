using System;
namespace Lession2
{
    class ArrayDemo
    {
        public static void Main(string[] args){
            // int[] intArr = new int[5];
            // int[] intArr = new int[5]{10,20,30,40,50};
            // for(int i =0; i< intArr.Length; i++){
            //     Console.WriteLine(intArr[i]);
            // }

            // int[] intArr = new int[5];
            // Random rnd = new Random();
            // for(int i =0; i< intArr.Length; i++){
            //     intArr[i] = rnd.Next(10,30);
            // }

            // for(int i =0; i< intArr.Length; i++){
            //     Console.WriteLine(intArr[i]);
            // }

            //Mảng 2 chiều (mảng nhiều chiều)
            
            // int[,] matrix = new int[2,3];
            // int[,] matrix = new int[2,3]{ 
            //                                 {1,2,3}, 
            //                                 {4,5,6} 
            //                             };
            // Random rnd = new Random();
            // for(int i = 0; i< matrix.GetLength(0); i++){
            //     for(int j=0; j< matrix.GetLength(1); j++){
            //         matrix[i,j] = rnd.Next(10,70);
            //     }
            // }

            // Console.WriteLine($"Row: {matrix.GetLength(0)}, column: {matrix.GetLength(1)}");
            // for(int i = 0; i< matrix.GetLength(0); i++){
            //     for(int j=0; j< matrix.GetLength(1); j++){
            //         Console.Write($"{matrix[i,j]} ");
            //     }
            //     Console.WriteLine();
            // }
            // int[][] matrix = new int[2][] {
            //                                 new int[4] { 1,2,3,4},
            //                                 new int[6] { 1,2,3,4,5,6}
            //                               };
            int[][] matrix = new int[2][];  
            Random rndCol = new Random();
            Random rndVal = new Random();
            for(int i = 0; i< matrix.Length; i++){
                int size = rndCol.Next(5,10);
                int[] arr = new int[size];
                for(int j=0; j< size; j++){
                    arr[j] = rndVal.Next(10,60);
                }
                matrix[i] = arr;
            }
            for(int i = 0; i< matrix.Length; i++){
                for(int j=0; j< matrix[i].Length; j++){
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
