using Delegates.Patterns.AbstractFactory;

namespace Delegates.Patterns.Builder
{
    public interface IVehiclePlan
    {
        public VehiclePart Engine { get; set; }
        public VehiclePart Wheels { get; set; }
        public VehiclePart Sunroof { get; set; }
        public VehiclePart SteeringWheel { get; set; }
    }
}