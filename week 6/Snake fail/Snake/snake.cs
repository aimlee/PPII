using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    class Snake
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Snake()
        {
            sign = 'Z';
            color = ConsoleColor.Green;
            body = new List<Point>() ;

            body.Add(new Point(16, 7));
            body.Add(new Point(15, 7));
            body.Add(new Point(14, 7));
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

        public void CollisionWithWall()
        {
            if (body[0].x < 14)
                body[0].x = 96;
            if (body[0].x > 96)
                body[0].x = 14;
            if (body[0].y < 7)
                body[0].y = 21;
            if (body[0].y > 21)
                body[0].y = 7;
        }

        public int a = 0;
        public bool CanEat(Food food)
        {

            if (food.Location.x == body[0].x && food.Location.y == body[0].y)
            {
                a++;
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
