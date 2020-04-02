using System;
using System.Collections.Generic;

namespace Polymorphism_methodOveride
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new List<Shapes>();
            
            shape.Add(new circle());
            shape.Add(new rectangle());
            shape.Add(new square());

            var canvas1 = new canvas();
            canvas1.DrawShapes(shape);
        }
    }
}
