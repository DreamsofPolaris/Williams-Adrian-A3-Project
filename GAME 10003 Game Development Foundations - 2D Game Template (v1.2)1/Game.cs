// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        // Place your variables here:
        Color background = new Color(0x00, 0x00, 0x00);
        Color obstacle = new Color(0xfe, 0x01, 0x9a);

        float[] xaxis = [];
        float[] yaxis = [];
        float pelletRadius = 10;
        float xCursor;
        float nightzone = 200;

        Vector2 circleZone = new Vector2(300, 600);
        int radius = 10;
        float num1 = 0;
        float num2 = 0;
        Vector2 circleBrick = new Vector2(80, 50);
        int brickRadius = 20;

        Vector2 bumperZone = new Vector2(300, 615);
        Vector2 bumperSize = new Vector2(200, 25);
        Vector2 zone = Input.GetMousePosition();

        Vector2 ballLastPosition;
        float ballDirectionX = 3f;
        float ballDirectionY = -3f;

        bool[] destroyedObstacle = new bool[10];


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Circle Break");

            Window.SetSize(600, 800);


        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(background);

            Draw.FillColor = Color.White;
            Draw.Circle(circleZone, radius);

            //Draw.FillColor = obstacle;
            //Draw.Circle(circleBrick, brickRadius);

            Draw.LineSize = 0;
            Draw.FillColor = obstacle;
            for (int i = 0; i < 2; i++)
            {
                int yoffset = i * 100;

                for (int j = 0; j < 5; j++)
                {
                    int xoffset = j * 100;
                    if (destroyedObstacle[i * 5 + j] == false)
                    {
                        Draw.Circle(circleBrick.X + xoffset, circleBrick.Y + yoffset, brickRadius);

                        if (Vector2.Distance(new Vector2(circleBrick.X + xoffset, circleBrick.Y + yoffset), circleZone) <= brickRadius + radius)
                        {
                            destroyedObstacle[i * 5 + j] = true;
                            ballDirectionX = -ballDirectionX;
                            ballDirectionY = -ballDirectionY;
                        }
                    }
                }
            }


            Draw.FillColor = obstacle;
            Draw.Rectangle(Input.GetMouseX() - 100, bumperZone.Y, bumperSize.X, bumperSize.Y);

            

            circleZone.Y += ballDirectionY;
            circleZone.X += ballDirectionX;

            ballCollision();
            bumperCollision();
        }

        public void ballCollision()
        {
            ballLastPosition = circleZone;
            bool pastBottom = circleZone.Y + radius >= Window.Height;
            bool pastTop = circleZone.Y - radius <= 0;
            bool pastLeft = circleZone.X - radius <= 0;
            bool pastRight = circleZone.X + radius >= Window.Width;

            if (pastBottom == true)
            {
                ballDirectionY = -3f;
                circleZone.Y = Window.Height - radius;
            }
            else if (pastTop == true)
            {
                ballDirectionY = 3f;
                circleZone.Y = 0 + radius;
            }
            else if (pastLeft == true)
            {
                ballDirectionX = 3f;
                circleZone.X = 0 + radius;
            }
            else if (pastRight == true)
            {
                ballDirectionX = -3f;
                circleZone.X = Window.Width - radius;
            }
        }
        public void bumperCollision()
        {
            bool bumperTop = 620 >= circleZone.Y + radius && circleZone.Y + radius >= 615;

            if (bumperTop == true && Input.GetMouseX() - 100 <= circleZone.X && circleZone.X <= Input.GetMouseX() + 100)
                {
                    ballDirectionY = -3;
                    circleZone.Y = bumperZone.Y - radius;
                    
                }
               
                }

        public void obstacleCollision()
        {
            bool bumperTop = 620 >= circleZone.Y + radius && circleZone.Y + radius >= 615;

            if (bumperTop == true && Input.GetMouseX() - 100 <= circleZone.X && circleZone.X <= Input.GetMouseX() + 100)
            {
                ballDirectionY = -3;
                circleZone.Y = bumperZone.Y - radius;

            }

        }
        /*
        MakeCloud();

        void MakeCloud()
        {
            Draw.LineSize = 0;
            Draw.FillColor = clouds;
            for (int i = 0; i < 2; i++)
            {
                int xoffset = i * 50;
                Draw.Circle(100 + xoffset, 200, 35);
            }
            for (int i = 0; i < 3; i++)
            {
                int xoffset = i * 50;
                Draw.Circle(80 + xoffset, 230, 35);
            }

        } */





    }
    }