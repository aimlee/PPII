using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Snake()
        {
            sign = 'Z';
            color = ConsoleColor.Black;
            body = new List<Point>() ;

            body.Add(new Point(16, 7));
            body.Add(new Point(15, 7));
            body.Add(new Point(14, 7));
        }

        public void Move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;

        }

        public void CollisionWithWall()
        {
            if (body[0].x < 0)
                body[0].x = 69;
            if (body[0].x > 69)
                body[0].x = 0;
            if (body[0].y < 0)
                body[0].y = 19;
            if (body[0].y > 19)
                body[0].y = 0;
        }

        public bool CanEat()
        {
            if (Game.food.Location.x == body[0].x && Game.food.Location.y == body[0].y)
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
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                i++;
            }
        }


    }
}
