using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC
{
    class Circle
    {
        public double r;
        public double a;
        public double p;

        public Circle()
        {
            r = 5;        }

        

        public Circle(double h)
        {
            r=h;
        }

        public void finds()
        {
            a = r*r*Math.PI;
        }

        public void findp()
        {
            p = 2 * Math.PI * r;
        }

        public override string ToString()
        {
            return r + "\n" + a + "\n" + p;
        }
    }
}