﻿using System;
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
            var (x, y) = myPoint;
            Console.WriteLine($"myPoint X: {x}, Y: {y}");

            /*******************************************************************
             * Output:
             * myPoint X: 5, Y: 3
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
