namespace Delegates.Patterns.Builder
{
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
}