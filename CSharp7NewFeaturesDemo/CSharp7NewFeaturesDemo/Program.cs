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
            var disc = CalculateDiscriminant();
            var rootDisc = Math.Sqrt(disc);
            return Tuple.Create(
                (-b-rootDisc) / (2*a),
                (-b+rootDisc) / (2*a)
                );

            // Location of function within the function doesn't matter.
            double CalculateDiscriminant() => b * b - 4 * a * c;
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
