using System.Collections.Generic;

namespace Delegates.Patterns
{
    public abstract class VehicleFactory
    {
        public abstract Vehicle Build(IEnumerable<PartsFactory> partsFactories = null);
    }
}