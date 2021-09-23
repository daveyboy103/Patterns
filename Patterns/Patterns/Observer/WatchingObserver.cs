using System;
using System.Collections.Generic;

namespace Delegates.Patterns.Observer
{
    public class WatchingObserver : IObserver
    {
        public void Update(IDictionary<string, decimal> prices)
        {
            foreach (var price in prices)
            {
                Console.WriteLine($"Watching: {price.Key} at {price.Value}");
            }
        }
    }
}