using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    class Game
    {
        public static Snake snake;
        public static wall Wall;
        public static Food food;
      

        public static void Gamesize()
        {
           
            Console.CursorVisible = false;
            Console.SetWindowSize(130, 30);

            snake = new Snake();
            Wall = new wall();
            food = new Food();

        }

        public static int a = 0;

        public static void Draw()
        {
            snake.Draw();
            food.Draw();
            Wall.Draw();
        }
        public static bool GameOver(wall wall)
        {
            for (int i = 1; i < snake.body.Count; i++)
            {
                if (snake.body[0].x == snake.body[i].x && snake.body[0].y == snake.body[i].y)
                    return true;
            }
            for (int i = 0; i < Wall.body.Count; i++)
            {
                if (snake.body[0].x == Wall.body[i].x && snake.body[0].y == Wall.body[i].y)
                    return true;
            }
            return false;

        }
    }

}
