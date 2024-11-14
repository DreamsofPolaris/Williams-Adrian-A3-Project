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

        Vector2 bumperZone = new Vector2(300, 620);
        Vector2 bumperSize = new Vector2(200, 25);
        Vector2 zone = Input.GetMousePosition();

        Vector2 ballLastPosition;
            float ballDirectionX = 3;
        float ballDirectionY = -3;



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
                    Draw.Circle(circleBrick.X + xoffset, circleBrick.Y + yoffset, brickRadius);
                }
            }
            Draw.FillColor = obstacle;
            Draw.Rectangle(Input.GetMouseX() - 100, bumperZone.Y, bumperSize.X, bumperSize.Y);
        }

        public void ballCollision()
        {

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