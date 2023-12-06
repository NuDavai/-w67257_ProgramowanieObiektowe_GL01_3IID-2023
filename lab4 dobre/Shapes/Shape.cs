using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Shapes
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Shape");
        }

    }
}
