namespace Delegates.Patterns.AbstractFactory
{
    public abstract class AbstractPartsFactory
    {
        public abstract PartsFactory GetPartsFactory(string vehicleType);
    }
}