using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FIT
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"F:\c# labs\quiz");
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo f in files)
            {
                StreamReader sm = new StreamReader(f.FullName);
                string l = sm.ReadLine();
                for(int i=0; i<l.Length; ++i)
                {
                    if(l[i]=='F'&& l[i+1]=='I' && l[i + 2] == 'T')
                    {
                        Console.WriteLine(f.Name);
                    }
                }
                continue;
            }

            Console.ReadKey();

        }

    }

}
