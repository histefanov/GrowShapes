using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowShapes
{
    internal class Circle : Shape
    {
        private double _radius;
        public Circle(int radius)
        {
            _radius = radius;
        }

        public override double GetArea() => Math.PI * Math.Pow(_radius, 2);
        public override double GetPerimeter() => 2 * Math.PI * _radius;
    }
}
