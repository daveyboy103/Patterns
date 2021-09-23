using System;

namespace Delegates.Patterns
{
    public class PartsFactoryMaker : AbstractPartsFactory
    {
        public override PartsFactory GetPartsFactory(string vehicleType)
        {
            if (vehicleType.ToUpper() == "VAN")
            {
                return new VanPartsFactory();
            }
            
            throw new NotImplementedException($"Vehicle Type [{vehicleType}] not implemented");
        }
    }
}