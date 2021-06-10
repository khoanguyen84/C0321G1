using System;
using System.IO;

namespace Lession15
{
    class FileDemo{
        public static void Main(string[] args){
            string path = @"C:\CodeGym\Class\C0321G1\Module2\Lession15\Data";
            string inputFilename = "input.txt";
            string ouputFilename = "output.txt";

            string data = "";
            
            using(StreamReader sr = File.OpenText($@"{path}/{inputFilename}")){
                data = sr.ReadToEnd();
            }

            string[] StrArr = data.Split(' ');
            int[] IntArr = new int[StrArr.Length];
            for(int i = 0; i < StrArr.Length; i++){
                IntArr[i] = int.Parse(StrArr[i]);
            }

            for(int i = 0; i < IntArr.Length; i++){
                IntArr[i] *= 2;
            }

            using(StreamWriter sw = File.CreateText($@"{path}/{ouputFilename}")){
                sw.Write(string.Join(' ', IntArr));
            }
        }

    }
}