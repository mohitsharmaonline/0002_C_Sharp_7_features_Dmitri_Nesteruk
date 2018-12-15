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

            // there are couple of rules, you can not rebind the variables
            // you can not go ahead with same variable to reference something else.
            //refToSecond = ref numbers[0];

            /*******************************************************************
             * ERROR
             * Feature 'ref reassignment' is not available in C# 7.0. please use 
             * language version 7.3 or greater.
             * This means this is going to be allowed in later versions
             * *****************************************************************/

            refToSecond = 123;
            Console.WriteLine(string.Join(",", numbers));

            /*************************************************************
             * Output
             * 1,123,3
             * **********************************************************/

            // The reference is going to persist even if the array is no longer available.
            Array.Resize(ref numbers, 1);
            // now the array is a of lenght 1 only, still we got our reference.
            Console.WriteLine($"Second = {refToSecond}, array size is {numbers.Length}");

            /***************************************************************
             * output
             * 1,123,3
             * Second = 123, array size is 1
             * ************************************************************/
            // we can still manipulate it like before
            refToSecond = 321;
            Console.WriteLine($"Second = {refToSecond}, array size is {numbers.Length}");

            /*******************************************************************************
             * 1,123,3
             * Second = 123, array size is 1
             * Second = 321, array size is 1
             * *****************************************************************************/
            // Below line will throw exception as array bounds are violated.
            //numbers.SetValue(321, 1);

            // Can't expect same from list.
            //var numberList = new List<int> { 1, 2, 3 };
            //ref int second = ref numberList[1];
            // Error will come:
            // Severity	Code	Description	Project	File	Line	Suppression State
            // Error CS0206  A property or indexer may not be passed as an out or ref parameter CSharp7NewFeaturesDemo  C: \Users\mohit\Documents\0002_C_Sharp_7_features_Dmitri_Nesteruk\CSharp7NewFeaturesDemo\CSharp7NewFeaturesDemo\Program.cs   64  Active

        }
    }
}
