using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeDB
{
    public enum Directions
    {
        //This is an ENUM class we are calling Directions
        //we use enums as we can define and classify the directions 
        //easier with in the game.
        Left,
        Right,
        Up, 
        Down
    }


    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings()
        {
            Width = 16;
            Height = 16;
            directions = "left";
        }
    }
}
