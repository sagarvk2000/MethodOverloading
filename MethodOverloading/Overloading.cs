using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Overloading
    {
        public int Calculation(int a, int b)
        {
            return a - b;
        }
        public double Calculation(double x, double y)
        {
            return x * y;
        }
        public double Calculation(int p, double q)
        {
            return p / q;
        }
    }
}
