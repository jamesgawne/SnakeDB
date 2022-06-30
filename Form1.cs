using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeDB
{
    public partial class Form1 : Form
    {
        //Define a List type to hold the parts of our snake
        //A list is much like an array but we have more control
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();


        //Crate a single Circle class we calling Food This is called instanciation 
        public Form1()
        {
            InitializeComponent();
            new Settings(); // Link the Settings Class to this Form.

            gameTimer.Interval = 1000 / Settings.Speed; //set the game speed to 1000 devided by the speed we set in settings.

            gameTimer.Tick += updateScreen;
            gameTimer.Start(); //start the game timer, In this simple game we are using the Timer as a game loop.
        }

        private void updateScreen(object sender, EventArgs e)
        {
            //each time the timer tics it will run this function
            if (Settings.GameOver == true)
            {
                //if the game over is true and the player presses enter
                //we will run the startGame() function
                if (Input.KeyPress(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {
                //if the game is not over then the following will be executed

                if (Input.KeyPress(Keys.Right) && Settings.direction != Directions.Left)
                {
                    Settings.direction = Directions.Right;
                } 
                else if (Input.KeyPress(Keys.Left) && Settings.direction != Directions.Right)
                {
                    Settings.direction = Directions.Left;
                }
                else if (Input.KeyPress(Keys.Up) && Settings.direction != Directions.Down)
                {
                    Settings.direction = Directions.Up;
                }
                else if (Input.KeyPress(Keys.Down) && Settings.direction != Directions.Up)
                {
                    Settings.direction = Directions.Down;
                }
                movePlayer();//Jump to movePlayer function, The way else if statments work is as soon as a condition is met
                //it will jump out of else.
            }
            picCanvas.Invalidate();//refresh the picture box we call picCanvas and update the graphics.
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            //the keyUp event will trigger the state change in Input Class
            Input.changeState(e.KeyCode, false);
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //The keyDown event will trigger the state change in the Input Class
            Input.changeState(e.KeyCode, true);
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            // this is where we will see the snake and its parts moving

            Graphics canvas = e.Graphics; // create a new graphics class called canvas

            if (Settings.GameOver == false)
            {
                // if the game is not over then we do the following

                Brush snakeColour; // create a new brush called snake colour

                // run a loop to check the snake parts
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        // colour the head of the snake black
                        snakeColour = Brushes.Black;
                    }
                    else
                    {
                        // the rest of the body can be green
                        snakeColour = Brushes.Green;
                    }
                    //draw snake body and head
                    canvas.FillEllipse(snakeColour,
                                        new Rectangle(
                                            Snake[i].X * Settings.Width,
                                            Snake[i].Y * Settings.Height,
                                            Settings.Width, Settings.Height
                                            ));

                    // draw food
                    canvas.FillEllipse(Brushes.Red,
                                        new Rectangle(
                                            food.X * Settings.Width,
                                            food.Y * Settings.Height,
                                            Settings.Width, Settings.Height
                                            ));
                }
            }
            else
            {
                // this part will run when the game is over
                // it will show the game over text and make the label 3 visible on the screen

                string gameOver = "Game Over \n" + "Final Score is " + Settings.Score + "\n Press enter to Restart \n";
                lblEndGame.Text = gameOver;
                lblEndGame.Visible = true;
            }
        }

        private void startGame()
        {
            // this is the start game function

            lblEndGame.Visible = false; // set label 3 to invisible
            new Settings(); // create a new instance of settings
            Snake.Clear(); // clear all snake parts
            Circle head = new Circle { X = 10, Y = 5 }; // create a new head for the snake
            Snake.Add(head); // add the gead to the snake array

            lblScrNum.Text = Settings.Score.ToString(); // show the score to the label 2

            generateFood(); // run the generate food function
        }

        private void movePlayer()
        {
            //this the the loop for the snakes parts
            for (int i = Snake.Count - 1; i > 0; i--)
            {
                if (i == 0)
                {
                    //Move the body with the head
                    switch (Settings.direction)
                    {
                        case Directions.Right:
                            Snake[i].X++;
                            break;
                            case Directions.Left:
                            Snake[i].X--;
                            break;
                        case Directions.Up:
                            Snake[i].Y--;
                            break;
                        case Directions.Down:
                            Snake[i].Y++;
                            break;
                    }

                    //restrict the snake from leaving the canvas
                    int maxXpos = picCanvas.Size.Width / Settings.Width;
                    int maxYpos = picCanvas.Size.Height / Settings.Height;
                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X > maxXpos || Snake[i].Y > maxYpos)
                    {
                        die();
                    }

                    //detect collition with the snakes body
                    for (int j = 0; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            //if yes then die
                            die();
                        }
                    }
                    

                    //detect eating food
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        //eat the food fuction is fired
                        eat();
                    }
                }
                else
                {
                    //if no collitions keep moving the Snakes head and the body will follow
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void generateFood()
        {
            int maxXpos = picCanvas.Size.Width / Settings.Width;
            int maxYpos = picCanvas.Size.Height / Settings.Height;

            Random rnd = new Random();
            food = new Circle { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
        }

        private void eat()
        {
            // add a part to body

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y

            };

            Snake.Add(body); // add the part to the snakes array
            Settings.Score += Settings.Points; // increase the score for the game
            lblScrNum.Text = Settings.Score.ToString(); // show the score on the label 2
            generateFood(); // run the generate food function
        }

        private void die()
        {
            // change the game over Boolean to true
            Settings.GameOver = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startGame();
        }
    }
}
