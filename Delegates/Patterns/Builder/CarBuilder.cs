namespace Delegates.Patterns.Builder
{
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
}