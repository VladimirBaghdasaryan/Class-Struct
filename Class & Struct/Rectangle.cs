using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class___Struct
{
    internal struct Rectangle
    {
        public int Lenght { get; set; }
        public int Width { get; set; }

        public Rectangle(int lenght, int width)
        {
            Lenght = lenght;
            Width = width;
        }

        public void RectangleSquare()
        {
            Console.WriteLine($"RectangleSquare:{Lenght * Width}");
        }
    }
}
