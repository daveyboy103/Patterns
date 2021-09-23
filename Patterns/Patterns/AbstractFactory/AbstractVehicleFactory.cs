namespace Delegates.Patterns.AbstractFactory
{
    public abstract class AbstractVehicleFactory
    {
        public abstract VehicleFactory GetFactory(string vehicleType);
    }
}