namespace Delegates.Patterns.Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        bool UnregisterObserver(IObserver observer);
        void UpdateObservers();
    }
}