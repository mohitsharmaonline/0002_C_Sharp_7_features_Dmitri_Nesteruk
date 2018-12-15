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
            // Feature: Ref Returns and Locals
            // References to local variables.
            int[] numbers = { 1, 2, 3 };
            ref int refToSecond = ref numbers[1];
            // now any change to refToSecond variable affects 
            // the second value in an array.
            // next line simply copies the value.
            var valueOfSecond = refToSecond;

            refToSecond = 123;
            Console.WriteLine(string.Join(",", numbers));

            /*************************************************************
             * Output
             * 1,123,3
             * **********************************************************/

        }
    }
}
