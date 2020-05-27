using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Kulia
    {
        public double Dlinna(double r)
        {
            return (r * 2 * pi);
        }
        public double Plosha(double r)
        {
            return Math.Pow(r, 2) * pi;
        }
        public double Amount(double r)
        {
            return (4 / 3) * Math.Pow(r, 3) * pi;
        }

        private double pi = 3.14;
    }
}
