using System;
using System.Collections.Generic;

namespace Delegates.Patterns.Observer
{
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
}