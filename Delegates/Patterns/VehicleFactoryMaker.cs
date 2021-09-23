using System;

namespace Delegates.Patterns
{
    public class VehicleFactoryMaker : AbstractVehicleFactory
    {
        public override VehicleFactory GetFactory(string vehicleType)
        {
            if (vehicleType.ToUpper() == "VAN")
            {
                return new VanFactory();
            } 
            
            if (vehicleType.ToUpper() == "CAR")
            {
                return new VanFactory();
            }

            throw new NotImplementedException($"Vehicle Type [{vehicleType}] not implemented");
        }
    }
}