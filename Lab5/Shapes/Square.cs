using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Shapes
{
    public class Square : Shape
    {
        public double X { get; set; }

        public override double CalulateArea()
        {
            return Math.Pow(X, 2);
        }
    }
}
