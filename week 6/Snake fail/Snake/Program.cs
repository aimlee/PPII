using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    
    class Program
    {


        Game game = new Game();


        public static int direction = 1;
        public static int speed = 100;



        static void MoveSnakeThread(object state)
        {
            

            while (!Game.GameOver(Game.Wall))
            {
                if (Game.snake.body[0].x < 13)
                    Game.snake.body[0].x = 96;
                if (Game.snake.body[0].x > 95)
                    Game.snake.body[0].x = 12;
                if (Game.snake.body[0].y < 8)
                    Game.snake.body[0].y = 21;
                if (Game.snake.body[0].y > 21)
                    Game.snake.body[0].y = 7;
                switch (direction) { 
                    case 1:
                        Game.snake.Move(1, 0);
                        break;
                    case 2:
                        Game.snake.Move(0, 1);
                        break;
                    case 3:
                        Game.snake.Move(-1, 0);
                        break;
                    case 4:
                        Game.snake.Move(0, -1);
                        break;
                       
                }
                if (Game.GameOver(Game.Wall))
                {
                    Game.snake.a = 0;

                    Console.Clear();

                    Game.snake.body = new List<Point>();
                    Game.snake.body.Add(new Point(16, 7));
                    Game.snake.body.Add(new Point(15, 7));
                    Game.snake.body.Add(new Point(14, 7));
                }

                if (Game.snake.CanEat(Game.food))
                {

                    Game.food.setRandomPosition();
                    Game.a++;

                }
                
                Game.Draw();
                Thread.Sleep(speed);
            }

            
        }
        static void MoveSnakeTimer(object state)
        {
           
            switch (direction)
            {
                case 1:
                    Game.snake.Move(1, 0);
                    break;
                case 2:
                    Game.snake.Move(0, 1);
                    break;
                case 3:
                    Game.snake.Move(-1, 0);
                    break;
                case 4:
                    Game.snake.Move(0, -1);
                    break;
            }
            Game.Draw();
        }
        static void ser()
        {
            FileStream fs = new FileStream(@"F:\c# labs\week 6\Snake fail\Snake\data.der", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, Game.snake);
            
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("     Score: ");
            Console.WriteLine("     "+Game.a);

            Game.Gamesize();

            if (Game.GameOver(Game.Wall))
            {
                Console.Clear();
                Game.snake.body = new List<Point>();

                Game.snake.body.Add(new Point(16, 7));
                Game.snake.body.Add(new Point(15, 7));
                Game.snake.body.Add(new Point(14, 7));
            }

            Thread t = new Thread(MoveSnakeThread);
            t.Start();
            

            while (!Game.GameOver(Game.Wall))
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        direction = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = 2;
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = 3;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = 1;
                        break;
                }


                
            }
            




        }
        
}
 
}
