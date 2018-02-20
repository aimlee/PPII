using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Game
    {
        public static Snake snake;
        public static wall Wall;
        public static Food food;
        public static bool Gameover;

        public static void Gamesize()
        {
            Gameover = false;
            Console.CursorVisible = false;
            Console.SetWindowSize(130, 30);

            snake = new Snake();
            Wall = new wall();
            food = new Food();

        }

        public static void Draw()
        {
            snake.Draw();
            food.Draw();
            Wall.Draw();

        }
    }

}
