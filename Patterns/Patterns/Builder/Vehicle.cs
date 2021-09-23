using Delegates.Patterns.AbstractFactory;

namespace Delegates.Patterns.Builder
{
    public class Vehicle : IVehiclePlan
    {
        public VehiclePart Engine { get; set; }
        public VehiclePart Wheels { get; set; }
        public VehiclePart Sunroof { get; set; }
        public VehiclePart SteeringWheel { get; set; }

        public override string ToString()
        {
            return $"{Engine.Name}, {Wheels.Name}, {Sunroof.Name}, {SteeringWheel.Name}";
        }
    }
}