using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public snake()
        {
            sign = 'O';
            color = ConsoleColor.Green;
            body = new List<Point>();
            body.Add(new Point(0, 1));
            body.Add(new Point(0, 2));
            body.Add(new Point(0, 3));

        }
        public void Move(int dx, int dy)
        {
            Point lastPoint = body[body.Count - 1];
            Console.SetCursorPosition(lastPoint.x, lastPoint.y);
            Console.Write(' ');
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;
        }
    
        public bool CanEat(Food food)
        {
            if (food.Location.x == body[0].x && food.Location.y == body[0].y)
            {
               
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                return true;
            }
            return false;
        }
        public void Draw()
        {
            int i = 0;
            foreach (Point p in body)
            {
                if (i == 0)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                {
                    Console.ForegroundColor = color;
                }
                    Console.SetCursorPosition(p.x, p.y);
                    Console.Write(sign);
                    i++;
                
            }

        }
    }
}
