using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7NewFeaturesDemo
{
    public class Shape
    {

    }

    public class Rectangle : Shape
    {
        public int Width, Height;
    }

    public class Circle : Shape
    {

    }

    class Program
    {       

        public void DisplayShape(Shape shape)
        {
            if(shape is Rectangle r)
            {
                // Use r
            }

            // variable r is available here too.

            if (!(shape is Circle notCircle))
            {
                // use notCircle here
            }

            // notCircle is available here too.

            switch(shape)
            {
                case Circle c:
                    // use c
                    break;
                case Rectangle sq when (sq.Height == sq.Width):
                    // use sq
                    break;
            }

            // unfortunately we haven't got here any kind of switching on tuples
            var z = (12, 23);
            switch(z)
            {
                // We still can't do it!
                case (0, 0):
                    // we have origin.
                    break;
            }
        }

        static void Main(string[] args)
        {
            // Feature 2: Pattern Matching
            // Unfortunately this feature is coming very slowly.
            // So in C#7 we never really get saveral features that could have been there
            // with pattern matching.            
        }
    }
}
