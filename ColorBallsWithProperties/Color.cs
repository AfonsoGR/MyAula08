using System;
using System.Collections.Generic;
using System.Text;

namespace ColorBallsWithProperties
{
    class Color
    {
        // Properties
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }
        // Propertie Grayscale
        public byte Grayscale => (byte)((Red + Green + Blue) / 3);

        // Constructor
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }
        // Constructor
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
    }
}