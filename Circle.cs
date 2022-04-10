using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Circle : Shape
    {
        public Circle(int Raduis) : base(Raduis)
        {
           
        }

        public override double CalculateSurfaceArea()
        {
            return Math.PI * Raduis * Raduis;
        }
    }
    class Program
    {
        static void Main()
        {
            //List   
           Shape C1 = new Circle(3);
            C1.CalculateSurfaceArea();
        }
    }
    
}
