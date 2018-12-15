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
            // Feature 3: Tuples
            // Tuples have already existed in C#
            // Logic of Deconstruction
            var me = (name: "mohit", age: 123);
            // here we are deconstructing the tuple into two variables, name and age.
            var (name, age) = me;

            // now you can make sure that even one of your type supports deconstruction
            // just like tuples.

        }
    }
}
