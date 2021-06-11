using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace Lession15
{
    public class MatrixDemo
    {
        public static void Main(string[] args)
        {
            string path = @"C:\CodeGym\Class\C0321G1\Module2\Lession15\Data";
            string filename = "matrix.txt";
            int row = 0;
            int col = 0;
            int[][] matrix;
            string line="";
            List<string> data = new List<string>();
            using(StreamReader sr = File.OpenText(Path.Combine(path, filename))){
                while((line = sr.ReadLine()) != null){
                    data.Add(line);
                    // string firstLine = sr.ReadLine();
                    // row = int.Parse(firstLine.Split(' ')[0]);
                    // col = int.Parse(firstLine.Split(' ')[2]);
                    // matrix = new int[row,col];
                }
            }
            row = int.Parse(data[0].Split(' ')[0]);
            col = int.Parse(data[0].Split(' ')[1]);
            matrix = new int[row][];
            for(int i=1; i < data.Count; i++){
                matrix[i-1] = data[i].Split(' ').Select(e => int.Parse(e)).ToArray();
            }

            for(int i=0; i < matrix.Length; i++){
                for(int j=0; j < matrix[i].Length; j++){
                    Console.Write($"{matrix[i][j]} ");
                }            
                Console.WriteLine();
            }
        }
    }
}
