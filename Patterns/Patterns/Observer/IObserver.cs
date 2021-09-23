using System.Collections.Generic;

namespace Delegates.Patterns.Observer
{
    public interface IObserver
    {
        void Update(IDictionary<string, decimal> prices);
    }
}