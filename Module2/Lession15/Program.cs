using System;
using System.IO;

namespace Lession15
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\CodeGym\Class\C0321G1\Module2\Lession15\Data";
            string filename = "log.txt";
            Directory.CreateDirectory($@"{path}");
            // Directory.Delete($@"{path}\{filename}",true);
            // using (StreamWriter sw = File.CreateText($@"{path}\{filename}"))
            // {
            //     sw.Write("Hello");
            //     sw.Write("CodeGym Hue");
            // }

            try
            {
                int[] array = new int[] { 1, 2};
                array[1] = 5;
                int number1 = 10;
                int number2 = 1;
                int result = number1 / number2;
            }
            catch(System.DivideByZeroException dzex){
                using (StreamWriter sw = File.AppendText($@"{path}\{filename}"))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")}: {dzex.Message}");
                }
            }
            catch(System.IndexOutOfRangeException iorex){
                using (StreamWriter sw = File.AppendText($@"{path}\{filename}"))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")}: {iorex.Message}");
                }
            }
            catch (System.Exception ex)
            {
                using (StreamWriter sw = File.AppendText($@"{path}\{filename}"))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")}: {ex.Message}");
                }
            }
            finally{
                using (StreamWriter sw = File.AppendText($@"{path}\{filename}"))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")}: End transaction.");
                }
            }


            using(StreamReader sr = File.OpenText($@"{path}\{filename}")){
                // Console.WriteLine(sr.ReadToEnd());
                string line = "";
                int count = 0;
                while((line = sr.ReadLine()) != null){
                    Console.WriteLine($"Line {++count}: {line}");
                }
            }
        }
    }
}
