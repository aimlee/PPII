using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filestream
{
    class Program
    { public static int a = 1000;
        public void SecondMin()
        {
            FileStream fs = new FileStream(@"F:\c# labs\quiz\min\min.txt", FileMode.Open, FileAccess.Read);
            StreamReader sm = new StreamReader(fs);

            string s = sm.ReadLine();

            string[] arr = s.Split(' ');

              
            
        for(int i=0; i<arr.Length; ++i)
            {
                int n = int.Parse(arr[i]);
                if (n < a)
                    a = n;
            }

            FileStream fw = new FileStream(@"F:\c# labs\quiz\min\mn.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fw);

            sr.Write("min prime = " + a);
            fs.Close();
            sr.Close();
            sm.Close();
            fw.Close();
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            a.SecondMin();
            Console.ReadKey();
        }
    }
}
