﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        Game Game;

        public static int direction = 1;
        public static int speed = 200;

        static void MoveSnakeThread(object state)
        {
            while (!Game.Gameover)
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

        static void Main(string[] args)
        {
            Game.Gamesize();


            Thread t = new Thread(MoveSnakeThread);
            t.Start();

            
            while (!Game.Gameover)
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