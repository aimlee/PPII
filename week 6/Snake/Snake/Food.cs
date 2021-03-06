﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        Snake Snake = new Snake();
        Wall Wall = new Wall();
        public char sign;
        public ConsoleColor  color;
        public Point Location;

        public Food()
        {
            sign = '*';
            color = ConsoleColor.Red;
            setRandomPosition();
        }
        public void setRandomPosition()
        {
            int x = new Random().Next(14, 96);
            int y = new Random().Next(7, 21);
            for (int z = 0; z < Wall.body.Count; ++z)
            {
             while(x != Wall.body[z].x && y != Wall.body[z].y)
                {
                    x = new Random().Next(14, 96);
                    y = new Random().Next(7, 21);
                }
            }
            for (int z = 0; z < Snake.body.Count; ++z)
            {
            while  (x != Snake.body[z].x && y != Snake.body[z].y)
                {
                    x = new Random().Next(14, 96);
                    y = new Random().Next(7, 21);
                }
            }

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
