using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_methodOveride
{
    public class Shapes
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            // virtual keyword tells us that this method can take different forms and this is called as polymorphism.
        }
    }

    public class circle : Shapes
    {
        public override void Draw() // Override keyword helps us to overide the Draw method.
        {
            base.Draw();
            Console.WriteLine("Draw a circle");
        }
    }

    public class rectangle : Shapes
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class square : Shapes
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Draw a square");
        }
    }
}
