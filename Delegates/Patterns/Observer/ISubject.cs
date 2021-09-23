using System;
using System.Collections.Generic;

namespace Delegates.Patterns.Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        bool UnregisterObserver(IObserver observer);
        void UpdateObservers();
    }

    public interface IObserver
    {
        void Update(IDictionary<string, decimal> prices);
    }

    public class Subject : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        
        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public bool UnregisterObserver(IObserver observer)
        {
            bool ret = false;
            
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
                ret = true;
            }

            return ret;
        }

        public void UpdateObservers()
        {
            Dictionary<String, decimal> prices = GetRandomPrices();
            foreach (var observer in _observers)
            {
                observer.Update(prices);
            }
        }

        private Dictionary<string, decimal> GetRandomPrices()
        {
            Dictionary<String, decimal> prices = new Dictionary<string, decimal>
            {
                {"IBM", new Random().Next()},
                {"Apple", new Random().Next()},
                {"Microsoft", new Random().Next()},
                {"Google", new Random().Next()}
            };
            
            return prices;
        }
    }

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