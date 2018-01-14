using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string l1 = Console.ReadLine();
            args = l1.Split(' ');
            foreach (string s in args)
            {


                int x = int.Parse(s);
                bool res = true;
                for (int i = 2; i * i <= x; ++i)
                {
                    if (x % i == 0)
                    {
                        res = false;

                        break;
                    }
                }
                if (res == true)
                {
                    Console.WriteLine(x + " ");
                }

            }
        }
    }
}