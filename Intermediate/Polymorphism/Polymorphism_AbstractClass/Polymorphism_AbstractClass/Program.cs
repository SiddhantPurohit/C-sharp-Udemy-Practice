using System;
using System.Collections.Generic;

namespace Polymorphism_AbstractClass
{
    public abstract class Shapes  //this is abstract class
    {
        public abstract void Draw();  //this is abstract method it can be used similar to vitual methods
    }

    public class circle : Shapes
    {
        public override void Draw () //override keyword is used to override the abstart methods
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class rectangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class canvas
    {
        public void DrawShapes (List<Shapes> shapes )
        {
            foreach (var shape in shapes)
                shape.Draw();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Shape1 = new List<Shapes>();
            Shape1.Add(new circle());
            Shape1.Add(new rectangle());

            var canvas1 = new canvas();
            canvas1.DrawShapes(Shape1);

        }
    }
}
