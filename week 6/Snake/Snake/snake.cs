﻿using System;
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
           
            color = ConsoleColor.Green;
            body = new List<Point>();
            body.Add(new Point(16, 7));
            body.Add(new Point(15, 7));
            body.Add(new Point(14, 7));
        }

        public void Move(int dx, int dy)
        {
            Point lastpoint = body[body.Count - 1];
            Console.SetCursorPosition(lastpoint.x, lastpoint.y);
            Console.Write(' ');

            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;

            }
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
            foreach(Point p in body)
            {
                if (i == 0)
                    Console.ForegroundColor = ConsoleColor.Blue;
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                i++;
            }
        }
       public bool GameOver(Wall Wall)
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            }
            for (int i = 0; i < Wall.body.Count; i++)
            {
                if (body[0].x == Wall.body[i].x && body[0].y == Wall.body[i].y)
                    return true;
            }
            return false;

        }
    }
}
