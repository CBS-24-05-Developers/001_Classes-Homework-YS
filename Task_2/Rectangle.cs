using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double s = side1 * side2;
            return s;
        }

        public double PerimeterCalculator()
        {
            double p = 2 * (side1 + side2);
            return p;
        }

        public double Area => AreaCalculator();

        public double Perimeter => PerimeterCalculator();
    }
}
