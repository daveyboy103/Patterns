using System.Collections.Generic;

namespace Delegates.Patterns.AbstractFactory
{
    public abstract class VehicleFactory
    {
        public abstract Vehicle Build(IEnumerable<PartsFactory> partsFactories = null);
    }
}