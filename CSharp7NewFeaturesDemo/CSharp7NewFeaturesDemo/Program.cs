using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7NewFeaturesDemo
{
    public class Person
    {
        private int _id;
        private static readonly Dictionary<int, string> _names = new Dictionary<int, string>();

        //new feature of c# 7, lambda expressions for constructor can be used only in c#7 onwards.
        public Person(int id, string name) => _names.Add(id, name);
        ~Person() => _names.Remove(_id);

        // we can use expression bodies even with gettters and setters also fro c# 7 onwards.
        public string Name
        {
            get => _names[_id];
            set => _names[_id] = value;
        }

        // These new features of C# were contributed by community, rather than made by Microsoft.
    }
    class Program
    {
        static void Main(string[] args)
        {  
            // Feature 6: Expression bodied members.
            // C# already have this concept of Expression bodies which lets you shorten the
            // methods, but now this idea has been extended to other things like constructors and getters
            // and setters and so on.
        }
    }
}
