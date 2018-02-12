using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(103, 17);
            snake Snake = new snake();
            Food Food = new Food();
            wall Wall = new wall();

            for (int i = 1; i < Snake.body.Count - 1; ++i)
            {
                if (Snake.body[0].x == Snake.body[i].x && Snake.body[0].y == Snake.body[i].y)
                {
                    Snake.body = new List<Point>();
                    Snake.body.Add(new Point(0, 1));
                    Snake.body.Add(new Point(0, 2));
                    Snake.body.Add(new Point(0, 3));

                }

                while (true)
            {

                Snake.Draw();
                Food.Draw();
                Wall.Draw();


                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        Snake.Move(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        Snake.Move(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        Snake.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        Snake.Move(1, 0);
                        break;
                }


                if (Snake.body[0].x < 0)
                    Snake.body[0].x = 102;
                if (Snake.body[0].x > 102)
                    Snake.body[0].x = 0;
                if (Snake.body[0].y < 0)
                    Snake.body[0].y = 16;
                if (Snake.body[0].y > 16)
                    Snake.body[0].y = 0;



                if (Snake.CanEat(Food))
                {
                    Food.setRandomPosition();
                }

            
                }
            }
        }
    }
}