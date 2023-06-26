using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Overloading o1 = new Overloading();
           int result1 = o1.Calculation(30, 20);
           double result2 = o1.Calculation(20.0,24.4);
           double result3 = o1.Calculation(30,5);

           Console.WriteLine(result1);
           Console.WriteLine(result2);
           Console.WriteLine(result3);
        }
    }
}
