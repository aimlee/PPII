﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        Snake snake = new Snake();
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public Wall()
        {
            color = ConsoleColor.Gray;
            sign = '|';


            body = new List<Point>();
           

                    LoadLevel(0);
             
        }
        public void LoadLevel(int n)
        {
            body.Clear();

            string Path = string.Format(@"F:\c# labs\week 5\level\num{0}.txt", n);
            FileStream sf = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(sf);
            string line = "";
            int i = 0;
            int row = 0;

            while (i < 25)
            {
                line = sr.ReadLine();
                for (int a = 0; a < line.Length; ++a)
                {
                    if (line[a] == '|')
                        body.Add(new Point(a, row));

                }

                i++; row++;
            }
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);

            }
        }
    }
}
