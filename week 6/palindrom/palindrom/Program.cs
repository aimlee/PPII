using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void f()
        {
            FileStream fs = new FileStream(@"F:\c# labs\week 6\palindrom.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();

            sr.Close();
            fs.Close();

            int a = s.Parse();

            for(int i=1; i<=10; ++i)
            {
                if (a / i == 0)
                {
                    
                }
            }
            
        }
        
        static void Main(string[] args)
        {
            
            int z = 0;
            for (int i = 0; i < s.Length; ++i)
                {
                    for (int j = s.Length-1; i >= 0; --i)
                    {
                        if(s[i]== s[j])
                    {
                        z++;
                    }
                    }
                }
            if (z == s.Length) Console.WriteLine("true");
        }
    }
}
