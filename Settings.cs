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
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }

        public static Directions direction { get; set; }

        public Settings()
        {
            //this defines the defaults that are set when the game starts
            Width = 16;
            Height = 16;
            Speed = 20;
            Score = 0;
            Points = 100;
            GameOver = true;
            direction = Directions.Down;
        }
    }
}
