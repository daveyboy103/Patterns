namespace Delegates.Patterns.AbstractFactory
{
    public abstract class VehiclePart
    {
        public string Name { get; set; }
    }
    
    public class Engine : VehiclePart{}
    public class Sunroof : VehiclePart{}
    public class Wheels : VehiclePart{}
}