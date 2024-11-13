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
        Color daySky = new Color(0x7f, 0xa8, 0xb5);
        Color nightSky = new Color(0x4c, 0x54, 0x9b);
        Color sun = new Color(0xff, 0xfd, 0x95);
        Color moon = new Color(0xfe, 0xfe, 0xfe);
        Color clouds = new Color(0x78, 0x78, 0x9e);

        float[] xaxis = [];
        float[] yaxis = [];
        float pelletRadius = 10;
        float xCursor;
        float nightzone = 200;

        Vector2 circleZone = new Vector2(300, 700);
        int radius = 10;
        float num1 = 0;
        float num2 = 0;
        Vector2 circleBrick = new Vector2(50, 50);
        int brickRadius = 10;

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
            Window.ClearBackground(daySky);

                Draw.FillColor = Color.White;
                Draw.Circle(circleZone, radius);
            }

           
                }
            }
        
    


