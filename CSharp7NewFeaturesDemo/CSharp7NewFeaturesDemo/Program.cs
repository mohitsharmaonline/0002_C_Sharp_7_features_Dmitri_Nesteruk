using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7NewFeaturesDemo
{    
    class Program
    {
        public string Name { get; set; }

        public Program(string name)
        {
            // New syntax allowed in C# 7.
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        }

        int GetValue(int n)
        {
            return n > 0 ? n + 1 : throw new Exception();
        }

        static void Main(string[] args)
        {
            // Feature 7: throw Expressions.
            // if you think about ternary expressions or null coalesing expressions 
            // you will really think about both of them to be identical. 
            // with C# 7 , we are kind of breaking that, because now a ternary expression 
            // and a conditional null coalesing expression can actually contain a throw 
            // staement as their part.

            int val = -2;
            try
            {
                var d = new Program("");
                val = d.GetValue(-1);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);                
            }
            finally
            {
                Console.WriteLine(val);
            }

            /*******************************************************************************
             * System.Exception: Exception of type 'System.Exception' was thrown.
             * at CSharp7NewFeaturesDemo.Program.GetValue(Int32 n) in C:\Users\mohit\Documen
             * ts\0002_C_Sharp_7_features_Dmitri_Nesteruk\CSharp7NewFeaturesDemo\CSharp7NewFeat
             * uresDemo\Program.cs:line 21
             * at CSharp7NewFeaturesDemo.Program.Main(String[] args) in C:\Users\mohit\Docum
             * ents\0002_C_Sharp_7_features_Dmitri_Nesteruk\CSharp7NewFeaturesDemo\CSharp7NewFe
             * aturesDemo\Program.cs:line 37
             * -2
             * ****************************************************************************/
        }
    }
}
