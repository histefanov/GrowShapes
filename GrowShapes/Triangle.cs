using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowShapes
{
    internal class Triangle : Shape
    {
        private double _aside;
        private double _bside;
        private double _cside;

        public Triangle(double a, double b, double c)
        {
            this._aside = a;
            this._bside = b;
            this._cside = c;
        }

        public override double GetArea()
        {
            double semiPerimeter = (_aside + _bside + _cside) / 2;
            return Math.Sqrt(semiPerimeter *
                            (semiPerimeter - _aside) * (semiPerimeter - _bside) * (semiPerimeter - _cside));
        }

        // TODO IMPLEMENT
        public override double GetPerimeter() => _bside + _cside + _aside;
    }
}
