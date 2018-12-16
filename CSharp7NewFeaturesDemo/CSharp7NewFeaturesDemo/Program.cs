using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp7NewFeaturesDemo
{
    class Program
    {
        public static async Task<long> GetDirectorySize(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
            {
                return 0;
                // now unfortunately this return of 0, would also actually imply creation of a 
                // task, even if you do not really need it.
            }
            return await Task.Run(() =>
                Directory.GetFiles(dir, "*.*").Sum(file => new FileInfo(file).Length)
                );

            // This is how you will implement it in C#6 and this is fine just that
            // even an empty directory implies creation of a Task.
        }

        static void Main(string[] args)
        {
            // Feature 8: generalized async return types
            // Another constraint with Async methods prior to C# 7 was that async methods
            // were required to return either void or Task for a Task of T.
            // now what C# 7 allows us to do is to return
        }
    }
}
