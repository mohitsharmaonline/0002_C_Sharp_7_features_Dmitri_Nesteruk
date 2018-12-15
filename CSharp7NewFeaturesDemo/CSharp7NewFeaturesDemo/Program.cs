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
            double CalculateDiscriminant(double aa, double bb, double cc)
            {
                return bb * bb - 4 * aa * cc;
            }

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
