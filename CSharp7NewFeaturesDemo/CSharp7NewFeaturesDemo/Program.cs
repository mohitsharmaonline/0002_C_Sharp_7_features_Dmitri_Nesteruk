using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp7NewFeaturesDemo
{
    class Program
    {       

        static void Main(string[] args)
        {
            // Feature 9: Literal Improvements

            // you can add underscores to the variables
            int a = 1_23_321; // Underscores should actually be used to delimit millions, thousands etc.
            // However they can be inserted anywhere.
            // you can add as many underscores as you like, all of them will be ignored by the compiler.
            int b = 123_321_________123;

            // valid on hexadecimals
            long h = 0xAB_BC_D123EF;

            // valid on binary
            var bin = 0b1110_0111_0111;

        }
    }
}
