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
            Console.SetWindowSize(103, 30);
            snake Snake = new snake();
            Food Food = new Food();
            wall Wall = new wall();

            

            while (true)
            {

                Snake.Draw();
                Food.Draw();
                Wall.Draw();
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("Score :");
                    Console.WriteLine(Snake.a);


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


                if (Snake.body[0].x < 14)
                    Snake.body[0].x = 96;
                if (Snake.body[0].x > 96)
                    Snake.body[0].x = 14;
                if (Snake.body[0].y < 7)
                    Snake.body[0].y = 21;
                if (Snake.body[0].y > 21)
                    Snake.body[0].y = 7;

                if (Snake.GameOver(Wall))
                {
                    Snake.a = 0;
                    
                        Snake.body.Clear();
                    

                    
             
                    Snake.body = new List<Point>();
                    Snake.body.Add(new Point(16, 7));
                    Snake.body.Add(new Point(15, 7));
                    Snake.body.Add(new Point(14, 7));
                }

                if (Snake.CanEat(Food))
                {
                        
                    Food.setRandomPosition();

                        
                    }

            
                }
            
        }
    }
}