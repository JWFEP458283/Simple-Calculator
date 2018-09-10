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
    public class Arithmetic
    {
        // Add the two doubles together
        public static double Add(double a, double b)
        {
            return (a + b);
        }

        // Subtract the two doubles
        public static double Subtract(double a, double b)
        {
            return (a - b);
        }

        // Divide the two doubles
        public static double Divide(double a, double b)
        {
            return ((double)a / b);
        }

        // Multiply the two doubles
        public static double Multiply(double a, double b)
        {
            return (a * b);
        }
    }
}
