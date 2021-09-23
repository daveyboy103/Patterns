using System;
using System.Collections.Generic;

namespace Delegates.Patterns.Observer
{
    public class TradingObserver : IObserver
    {
        public void Update(IDictionary<string, decimal> prices)
        {
            foreach (var price in prices)
            {
                Console.WriteLine($"Trading: {price.Key} at {price.Value}");
            }
        }
    }
}