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
            int[] moreNumbers = { 10, 20, 30 };
            ref int refToThirty = ref Find(moreNumbers, 30);
            refToThirty = 1000;

            Console.WriteLine(string.Join(",", moreNumbers));

            /*************************************************************
             * output
             * 10,20,1000
             * **********************************************************/

            // this leads to misuse similar to that in C++
            Find(moreNumbers, 10) = 555;
            Console.WriteLine(string.Join(",", moreNumbers));

            /**********************************************************
             * Output
             * 10,20,1000
             * 555,20,1000
             * *******************************************************/
        }

        // now we will see some of the limitations of these concepts of ref 
        // by writing a min function.
        static ref int Min(ref int x, ref int y)
        {
            // only this will work.
            if(x < y)
            {
                return ref x;
            }
            return ref y;
        }

        static ref int Find(int[] numbers, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == value)
                {
                    return ref numbers[i];
                }
            }

            //return -1;
            // Error
            // Severity	Code	Description	Project	File	Line	Suppression State
            // Error CS8150  By - value returns may only be used in methods that return by value CSharp7NewFeaturesDemo  C: \Users\mohit\Documents\0002_C_Sharp_7_features_Dmitri_Nesteruk\CSharp7NewFeaturesDemo\CSharp7NewFeaturesDemo\Program.cs   82  Active

            //int fail = -1;
            //return ref fail;

            // Error:
            // Severity	Code	Description	Project	File	Line	Suppression State
            // Error CS8168  Cannot return local 'fail' by reference because it is not a ref local CSharp7NewFeaturesDemo  C: \Users\mohit\Documents\0002_C_Sharp_7_features_Dmitri_Nesteruk\CSharp7NewFeaturesDemo\CSharp7NewFeaturesDemo\Program.cs   88  Active

            // below is the only way to deal with it.
            throw new ArgumentException("meh");

        }

    }
}
