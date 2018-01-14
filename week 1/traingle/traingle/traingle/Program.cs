using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APT
{
    class Program
    {
        static void Main(string[] args)
        {
            RTraingle t = new RTraingle(3, 1, 2);
            t.findp();
            t.finds();
            Console.WriteLine(t);


            Console.ReadKey();
        }
    }
}
