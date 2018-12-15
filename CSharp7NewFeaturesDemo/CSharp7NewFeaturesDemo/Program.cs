using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7NewFeaturesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // now you can make sure that even one of your type supports deconstruction
            // just like tuples.
            var myPoint = new Point { X = 5, Y = 3 };
            // now you want to deconstruct your point:
            // if you don't care about the second return value.
            var (x, _) = myPoint;
            Console.WriteLine($"myPoint X: {x}");

            /*******************************************************************
             * Output:
             * myPoint X: 5
             *****************************************************************/
        }

        public class Point
        {
            public int X, Y;

            public void Deconstruct(out int x, out int y)
            {
                x = X;
                y = Y;
            }
        }
    }
}
