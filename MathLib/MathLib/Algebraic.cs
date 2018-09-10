/*
 * Name: Jaidan Escott
 * Date: 3/09/18
 * Version: 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Algebraic
    {
        // Calculate the square root of the double
        public static double SQRT(double a)
        {
            return Math.Sqrt(a);
        }

        // Calculate the cube root of the double
        public static double CBRT(double a)
        {
            return Math.Pow(a, (1.0 / 3.0));
        }

        // Calculate the inverse of the double
        public static double Inverse(double a)
        {
            return 1 / a;
        }
    }
}
