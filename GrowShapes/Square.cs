using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowShapes
{
    internal class Square : Shape
    {
        private double _side;

        public Square(double a)
        {
            this._side = a;
        }

        public override double GetArea() => _side * _side;
        public override double GetPerimeter() => 4 * _side;
    }
}
