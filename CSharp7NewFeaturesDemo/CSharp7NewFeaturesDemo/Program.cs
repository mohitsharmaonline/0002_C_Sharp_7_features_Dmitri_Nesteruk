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

            // you can also store parts of the tuple in their own saparate variables.
            // we are explicitely declarring types and name of variables here
            (double ss, double pp) = NewSumAndProduct(2, 3);

            // Second approach lets you infer the types.
            var (sum1, product1) = NewSumAndProduct(1, 2);

            // you can also declare variables beforehand
            double s, p;
            (s, p) = NewSumAndProduct(1, 2);

            // using tuples right inside main code.
            var me = (name: "mohit", age: 230);
            Console.WriteLine(me);
            Console.WriteLine(me.GetType());

            /**************************************************************************
             * Output
             * sum = 7, product = 10
             * sum = 7, product= 10
             * System.ValueTuple`2[System.Double,System.Double]
             * (mohit, 230)
             * System.ValueTuple`2[System.String,System.Int32]
             * **********************************************************************/

            Console.WriteLine($"My name is {me.name}, I am {me.age} years old.");

            // a tyuple type can be used anywhere other types can be.
            var snp = new Func<double, double, (double sum, double product)>((a, b) => (a + b, a * b));
            var result = snp(1, 2);
            Console.WriteLine($"sum = {result.sum}");

            /********************************************************************************
             * Output
             * sum = 7, product = 10
             * sum = 7, product= 10
             * System.ValueTuple`2[System.Double,System.Double]
             * (mohit, 230)
             * System.ValueTuple`2[System.String,System.Int32]
             * My name is mohit, I am 230 years old.
             * sum = 3
             * ******************************************************************************/ 
              
        }
    }
}
