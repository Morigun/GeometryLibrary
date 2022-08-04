
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Figures
{
    public class Triangle : Figure
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        private double CalculateSemiperimetr()
        {
            return (A + B + C) / 2;
        }

        public override double CalculateArea()
        {
            double p = CalculateSemiperimetr();
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public bool IsIsosceles()
        {
            return A == B || A == C || B == C;
        }
    }
}
