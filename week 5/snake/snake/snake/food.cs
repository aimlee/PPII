using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Food
    {
        public Point Location;
        public char sign;
        public ConsoleColor color;

            public Food()
        {
            sign = '*';
            color = ConsoleColor.Red;
            setRandomPosition();
        }
        public void setRandomPosition()
        {
            int x = new Random().Next(0, 103);
            int y = new Random().Next(0, 17);
            Location = new Point(x, y);
        }   
        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(Location.x, Location.y);
            Console.Write(sign);

        }
    }
}
