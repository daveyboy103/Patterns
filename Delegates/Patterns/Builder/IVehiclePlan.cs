namespace Delegates.Patterns.Builder
{
    public interface IVehiclePlan
    {
        public VehiclePart Engine { get; set; }
        public VehiclePart Wheels { get; set; }
        public VehiclePart Sunroof { get; set; }
        public VehiclePart SteeringWheel { get; set; }
    }

    public interface IVehicleBuilder
    {
        public void BuildEngine(string spec);
        public void BuildWheels(string spec);
        public void BuildSunroof(string spec);
        public void BuildSteeringWheel(string spec);
        
        public Vehicle Vehicle { get; }
    }

    public class CarBuilder : IVehicleBuilder
    {
        public CarBuilder()
        {
            _vehicle = new Vehicle();
        }
        
        private readonly Vehicle _vehicle;
        
        public void BuildEngine(string spec)
        {
            _vehicle.Engine = new Engine() {Name = $"Car Engine - {spec}"};
        }

        public void BuildWheels(string spec)
        {
            _vehicle.Wheels = new Wheels() {Name = $"Car Wheels - {spec}"};
        }

        public void BuildSunroof(string spec)
        {
            _vehicle.Sunroof = new Sunroof() {Name = $"Car Sunroof - {spec}"};
        }

        public void BuildSteeringWheel(string spec)
        {
            _vehicle.SteeringWheel = new SteeringWheel() {Name = $"Car Engine - {spec}"};
        }

        public Vehicle Vehicle => _vehicle;
    }
    
    public class VanBuilder : IVehicleBuilder
    {
        public VanBuilder()
        {
            _vehicle = new Vehicle();
        }
        
        private readonly Vehicle _vehicle;
        
        public void BuildEngine(string spec)
        {
            _vehicle.Engine = new Engine() {Name = $"Van Engine - {spec}"};
        }

        public void BuildWheels(string spec)
        {
            _vehicle.Wheels = new Wheels() {Name = $"Van Wheels - {spec}"};
        }

        public void BuildSunroof(string spec)
        {
            _vehicle.Sunroof = new Sunroof() {Name = $"Van Sunroof - {spec}"};
        }

        public void BuildSteeringWheel(string spec)
        {
            _vehicle.SteeringWheel = new SteeringWheel() {Name = $"Van Engine - {spec}"};
        }

        public Vehicle Vehicle => _vehicle;
    }
    
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