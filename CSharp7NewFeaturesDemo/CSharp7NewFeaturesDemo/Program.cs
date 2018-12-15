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
            if(shape is Rectangle)
            {
                var rc = (Rectangle)shape;
            }

            var rect = shape as Rectangle;
            if(rect != null)
            {
                // use rect
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
