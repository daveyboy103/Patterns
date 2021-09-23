using System.Collections.Generic;

namespace Delegates.Patterns
{
    public abstract class PartsFactory
    {
        public abstract IEnumerable<VehiclePart> GetParts();
    }
}