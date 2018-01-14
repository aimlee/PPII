using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASR
{
    class Rectangle
    {
        public int w;
        public int h;
        public int area;
        public int per;
        
       
        public Rectangle(int a, int b) {
            w = a;
            h = b;
        }
        public Rectangle() {
            w = 4;
            h = 5;
        }
        public Rectangle(int b)
        {
            h = b;
            w = 10;
        }
        public void finds()
        {
            area = w * h;
        }
        public void findp()
        {
            per = (w + h) * 2;
        }
        public override string ToString()
        {
            return w + "\n" + h + "\n" + area + "\n" + per;
        }

    }
}
