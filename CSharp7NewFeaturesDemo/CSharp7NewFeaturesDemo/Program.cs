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
            // Old way before c# 7: variable declaratio is outside.
            DateTime dt;
            if(DateTime.TryParse("01/01/2017", out dt))
            {
                Console.WriteLine(dt);
            }
        }
    }
}
