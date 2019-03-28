using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    public struct MonterCarlo
    {
        public double X, Y;

        public MonterCarlo(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public MonterCarlo(Random randomValue)
        {
            this.X = randomValue.NextDouble();
            this.Y = randomValue.NextDouble();
        }

        public double Monte()
        {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
        }
    }
}
