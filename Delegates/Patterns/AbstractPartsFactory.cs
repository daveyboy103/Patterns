namespace Delegates.Patterns
{
    public abstract class AbstractPartsFactory
    {
        public abstract PartsFactory GetPartsFactory(string vehicleType);
    }
}