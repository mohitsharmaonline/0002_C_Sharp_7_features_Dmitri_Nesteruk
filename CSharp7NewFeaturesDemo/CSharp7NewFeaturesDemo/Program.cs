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

        static (double sum, double product) NewSumAndProduct(double a, double b)
        {
            return (a + b, a * b);
        }

        static void Main(string[] args)
        {
            // Feature 3: Tuples
            // Tuples have already existed in C#
            var sp = SumAndProduct(2, 5);

            // here is exacly where the fun ends before C# 7
            Console.WriteLine($"sum = {sp.Item1}, product = {sp.Item2}");

            var sp2 = NewSumAndProduct(2, 5);
            Console.WriteLine($"sum = {sp2.sum}, product= {sp2.product}");
            Console.WriteLine(sp2.GetType());
        }
    }
}
