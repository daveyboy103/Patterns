using System.Collections;
using System.Threading;

namespace Delegates.Patterns
{
    public abstract class AbstractVehicleFactory
    {
        public abstract VehicleFactory GetFactory(string vehicleType);
    }
}