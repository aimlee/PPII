using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        

        public static int direction = 1;
        public static int speed = 200;

        static void MoveSnakeThread(object state)
        {
            Snake snake = new Snake();
            Food food = new Food();
            Wall wall = new Wall();
            while (!snake.GameOver(wall))
            {
                switch (direction)
                {
                    case 1:
                snake.Move(1, 0);
                        break;
                    case 2:
                        snake.Move(0, 1);
                        break;
                    case 3:
                        snake.Move(-1, 0);
                        break;
                    case 4:
                        snake.Move(0, -1);
                        break;
                }
                
                Thread.Sleep(speed);
            }

        }

        static void Main(string[] args)
        {

            
            Thread t = new Thread(MoveSnakeThread);
            t.Start();

            Snake snake = new Snake();
            Food food = new Food();
            Wall Wall = new Wall();
            Console.CursorVisible = false;
            Console.SetWindowSize(103, 30);
            
            while (true)
            {

                snake.Draw();
                food.Draw();
                Wall.Draw();
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("Score :");
                Console.WriteLine(snake.a);


                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        direction = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = 3;
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = 2;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = 1;
                        break;
                }


                if (snake.body[0].x < 14)
                    snake.body[0].x = 96;
                if (snake.body[0].x > 96)
                    snake.body[0].x = 14;
                if (snake.body[0].y < 7)
                    snake.body[0].y = 21;
                if (snake.body[0].y > 21)
                    snake.body[0].y = 7;

                if (snake.GameOver(Wall))
                {
                    snake.a = 0;

                    Console.Clear();

                    snake.body = new List<Point>();
                    snake.body.Add(new Point(16, 7));
                    snake.body.Add(new Point(15, 7));
                    snake.body.Add(new Point(14, 7));
                }
                if (snake.CanEat(food))
                {

                    food.setRandomPosition();


                }

            }
        }
    }
}
