using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7NewFeaturesDemo
{
    class Program
    {
        static Tuple<double, double> SumAndProduct(double a, double b)
        {
            return Tuple.Create(a + b, a * b);
        }

        static void Main(string[] args)
        {
            // Feature 3: Tuples
            // Tuples have already existed in C#
            var sp = SumAndProduct(2, 5);

            // here is exacly where the fun ends before C# 7
            Console.WriteLine($"sum = {sp.Item1}, product = {sp.Item2}");
        }
    }
}
