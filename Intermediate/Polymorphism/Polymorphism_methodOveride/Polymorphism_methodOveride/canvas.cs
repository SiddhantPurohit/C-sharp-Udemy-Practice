using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_methodOveride
{
    class canvas
    {
        public void DrawShapes(List<Shapes> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
