using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWrite
{
    class Program
    {


        
            
             
        
       
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"F:\c# labs\week 2\2 lab\qw.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string a = sr.ReadLine();
            sr.Close();
            fs.Close();
            string[] arr = a.Split(' ');
            int max = int.Parse(arr[0]);
            int min = int.Parse(arr[0]);
            for (int i = 0; i < arr.Length; ++i)
            {
                if (int.Parse(arr[i]) > max)
                {
                    max = int.Parse(arr[i]);
                }
                if (int.Parse(arr[i]) < min)
                {
                    min = int.Parse(arr[i]);
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);

            Console.ReadKey();

        }
    }
}