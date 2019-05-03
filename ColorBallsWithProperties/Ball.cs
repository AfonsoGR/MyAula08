using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBallsWithProperties
{
    class Ball
    {
        // Instance variables
        private Color color;
        private float radius;
        // Propertie of times thrown
        public int XThrown { get; private set; }

        // Constructor that accepts color and radius and degines xThrown
        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            XThrown = 0;
        }

        // Method that bursts the ball
        public void Burst()
        {
            radius = 0;
        }

        // Method that throws the balls
        public void Yeet()
        {
            if (radius > 0)
            {
                XThrown++;
            }
        }
    }
}
