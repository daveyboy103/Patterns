namespace Delegates.Patterns.Builder
{
    public interface IVehicleBuilder
    {
        public void BuildEngine(string spec);
        public void BuildWheels(string spec);
        public void BuildSunroof(string spec);
        public void BuildSteeringWheel(string spec);
        
        public Vehicle Vehicle { get; }
    }
}