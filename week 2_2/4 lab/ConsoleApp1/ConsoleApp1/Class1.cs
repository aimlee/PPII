using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Complex
    {
        public int x, y;

        public Complex() { }

        public Complex(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        static int GCD(int[] numbers)
        {
            return numbers.Aggregate(GCD);
        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex n = new Complex();
            n.x = (c1.x * c2.y+ c2.x * c1.y)/GCD(c1.x * c2.y + c2.x * c1.y, c1.y * c2.y);
            n.y = (c1.y *c2 .y)/GCD(c1.x * c2.y + c2.x * c1.y, c1.y * c2.y);
            return n;
        }

        public override string ToString()
        {
            return x + " " + y;
        }


    }
}