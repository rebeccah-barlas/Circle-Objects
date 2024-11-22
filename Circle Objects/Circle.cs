using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    internal class Circle
    {
        private double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateDiameter()
        {
            return Radius *2;
        }
        public double CalculateCircumfrence()
        {
            return 2 * Math.PI * Radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public void Grow()
        {
            Radius = Radius * 2;
        }
        public double GetRadius()
        {
            return Radius;
        }
    }
}
