using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(4);

            c.findp();
            c.finds();

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
