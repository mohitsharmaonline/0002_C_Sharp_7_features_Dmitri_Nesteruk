using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7NewFeaturesDemo
{

    public class EquationSolver
    {
        public static Tuple<double, double>
            SolveQuadratic(double a, double b, double c)
        {
            // To solve a quadratic equation, first
            // we need to figure out a discriminate, which is 
            // b*b-4*a*c

            // one place where we can calculate disciminant is inside a Func
            var CalculateDiscriminant = new Func<double, double, double, double>(
                (aa, bb, cc) => bb * bb - 4 * aa * cc);
            // this is lengthy, but it works!

            var disc = CalculateDiscriminant(a, b, c);
            var rootDisc = Math.Sqrt(disc);
            return Tuple.Create(
                (-b-rootDisc) / (2*a),
                (-b+rootDisc) / (2*a)
                );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Local Functions
            // this feature already existed in C# but under a disguise.
            var result = EquationSolver.SolveQuadratic(1, 10, 16);
            Console.WriteLine(result);

            /****************************************************
             * Output:
             * (-8, -2)
             * **************************************************/
        }
    }
}
