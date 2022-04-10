using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    internal class Triangle : Shape
    {
        public Triangle(int Width, int Height) : base(Width, Height)
        {
        }

        public override double CalculateSurfaceArea()
        {
            return 0.5 *(Height* Width);
        }
    }
}
