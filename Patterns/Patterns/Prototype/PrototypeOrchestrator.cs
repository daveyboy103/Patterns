namespace Delegates.Patterns.Prototype
{
    public class PrototypeOrchestrator
    {
        public Animal GetClone(Animal animal)
        {
            return (Animal) animal.Clone();
        }
    }
}