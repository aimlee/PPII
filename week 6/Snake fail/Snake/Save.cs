using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    class Save

    {
        public Snake snake;
        public wall Wall;
        public Food food;
        
        public Save() {
            snake = Game.snake;
            Wall = Game.Wall;
            food = Game.food;
        }


    }
}
