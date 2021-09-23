using System.Collections.Generic;

namespace Delegates.Patterns.Iteratror
{
    public static class DataSource 
    {
        public static IList<string> Strings => new List<string> { "Peter", "Paul", "Mary", "Stan", "Ollie", "David", "Ciaran", "Karen" };
    }
}