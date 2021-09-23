using System.Collections.Generic;

namespace Delegates.Patterns.AbstractFactory
{
    public abstract class PartsFactory
    {
        public abstract IEnumerable<VehiclePart> GetParts();
    }
}