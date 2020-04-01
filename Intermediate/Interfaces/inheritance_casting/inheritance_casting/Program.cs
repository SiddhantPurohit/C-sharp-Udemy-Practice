using System;

namespace inheritance_casting
{
    class shapes
    {
        public static int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw ()
        {
            Console.WriteLine("Drawing the shape");
        }


    }

    class text : shapes
    {
        public static int FontSize { get; set; }
        public string FontName { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            text.Width = 100;
            shapes.Width = 200;
            Console.WriteLine(text.Width); //pointing to same memory location

            //downcasting
            shapes newshape1 = new text(); //here shape class is downcasted to text class
            // newshape1.Fontsize  = 10; // here fontsize is not acessible as it is not the property of text class


        }
    }
}
