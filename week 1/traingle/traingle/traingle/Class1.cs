using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APT
{
    class RTraingle
    {
        public int a;
        public int b;
        public int c;
        public int area;
        public int per;
        public RTraingle()
        {
            a = 3;
            b = 2;
            c = 4;
        }
        public RTraingle(int k)
        {
            a = 3;
            b = k;
            c = 4;
        }
        public RTraingle(int k1,int  k2,int k3)
        {
            a = k1;
            b = k2;
            c = k3;
        }
        public void finds()
        {
            area = a*b/ 2;
        }
        public void findp()
        {
            per = a + b + c;

        }
        public override string ToString()
        {
            return a + "\n" + b + "\n" + c + "\n" + area + "\n" + per;
        }
    }
}
