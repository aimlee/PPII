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


        static void f()
        {
            char max='0';
            char min='9';
            FileStream fs = new FileStream(@"F:\c# labs\week 2\2 lab\qw.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            
             string number = sr.ReadLine();
             
          for(int i = 0; i < number.Length; i++)
            {
                
                if (number[i] > max) { max = number[i];  }
                
                if (number[i] < min && number[i]>48) { min = number[i]; }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            sr.Close();
            fs.Close();
        }
       
        static void Main(string[] args)
        {
            f();


            Console.ReadKey();

        }
    }
}