using Lab4.Shapes;
using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad1();
        }

        static void Zad1()
        {
            var shapes = new List<Shape>();
            var shape1 = new Rectangle()
            {
                X = 5,
                Width = 2
            };

            shape1.Height = 3;

            shapes.Add(shape1);
            shapes.Add(new Rectangle()
            {
                X = 5,
                Width = 7
            });
            shapes.Add(new Rectangle()
            {
                X = 5,
                Width = 6
            });
            shapes.Add(new Rectangle()
            {
                X = 4,
                Width = 2
            });

            foreach(var shape in shapes)
            {
                shape.Draw();
            }
            for(int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw();
            }
        }
    }
}
