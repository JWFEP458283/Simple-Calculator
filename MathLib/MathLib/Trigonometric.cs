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
    public class Trigonometric
    {
        // Calculate the tangent of the double
        public static double Tan(double a)
        {
            return Math.Tan(a * (Math.PI / 180));
        }

        // Calculate the sine of the double
        public static double Sine(double a)
        {
            return Math.Sin(a * (Math.PI / 180));
        }

        // Calculate the cosine of the double
        public static double Cosine(double a)
        {
            return Math.Cos(a * (Math.PI / 180));
        }
    }
}
