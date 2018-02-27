using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    class wall
    {
        public List<Point> body;
        public char sign, sign2;
        public ConsoleColor color;

        public wall()
        {
            color = ConsoleColor.White;
            sign = '|';
            sign2 = '*';


            body = new List<Point>();

            LoadLevel(0);
        }

        public void LoadLevel(int num)
        {
            body.Clear();

            string Path = string.Format(@"F:\c# labs\week 5\level\num{0}.txt", num);
            FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = "";
            int i = 0;
            int row = 0;

            while (i < 25)
            {
                line = sr.ReadLine();
                for (int a = 0; a < line.Length; a++)
                {
                    if (line[a] == '|' || line[a] == '*')
                    {
                        body.Add(new Point(a, row));
                    }
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
                Console.Write(sign2);
            }
        }
    }
}
