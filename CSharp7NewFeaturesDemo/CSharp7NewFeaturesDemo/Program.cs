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
            // Feature 1: Out Variables
            if (DateTime.TryParse("02/02/2016", out var dt))
            {
                Console.WriteLine(dt);
            }

            // Interestingly the variable dt is now available outside the
            // block where it is defined too. For example:
            Console.WriteLine($"dt outside block: {dt}");

            /*********************************************************
             *  Output
             *  2/2/2016 12:00:00 AM
             *  dt outside block: 2/2/2016 12:00:00 AM
            ********************************************************/

            // What if the parsing fails and we use out variable?
            int.TryParse("abc", out var i);
            Console.WriteLine($"value of i after parsing fails: {i}");

            /*********************************************************
             *  Output
             *  2/2/2016 12:00:00 AM
             *  dt outside block: 2/2/2016 12:00:00 AM
             *  value of i after parsing fails: 0
            *********************************************************/
            // so in the above case output will be the default value of variable data type.
        }
    }
}
