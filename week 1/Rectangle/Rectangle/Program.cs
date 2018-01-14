using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASR
{
    class Program 
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5);
            r.finds();
            r.findp();

            Console.WriteLine(r);
            Console.ReadKey();
           
        }
    }
}
