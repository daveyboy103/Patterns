using System;
using System.Linq;
using System.Text;

namespace Delegates.Patterns.Iteratror
{
    public class TestIterations
    {
        public void Test()
        {
            Console.WriteLine("Starts with P");
            foreach (var name in DataSource.Strings.Where(x => x.StartsWith("P")))
            {
                Console.WriteLine(name);
            }
            
            Console.WriteLine("Length > 4");
            foreach (var name in DataSource.Strings.Where(x => x.Length > 4))
            {
                Console.WriteLine(name);
            }            
            
            Console.WriteLine("Reversed");
            foreach (var name in DataSource.Strings.Select(x =>
            {
                var rev = x.Reverse();

                StringBuilder sb = new StringBuilder();

                foreach (char c in rev)
                {
                    sb.Append(c);
                }

                return sb.ToString();
            }))
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Skip 4");
            foreach (var name in DataSource.Strings.Skip(4))
            {
                Console.WriteLine(name);
            }             
            
            Console.WriteLine("Take 4");
            foreach (var name in DataSource.Strings.Take(4))
            {
                Console.WriteLine(name);
            } 
            
            Console.WriteLine("Skip 4 - Take 1");
            foreach (var name in DataSource.Strings.Skip(4).Take(1))
            {
                Console.WriteLine(name);
            }
            
            Console.WriteLine("Sorted");
            foreach (var name in DataSource.Strings.OrderBy(x => x))
            {
                Console.WriteLine(name);
            } 
            
            Console.WriteLine("Sorted by Last Letter");
            foreach (var name in DataSource.Strings.OrderBy(x => x.Last()))
            {
                Console.WriteLine(name);
            } 

            
        }
    }
}