using System.Collections.Generic;

namespace Delegates.Patterns
{
    public abstract class Vehicle
    {
        protected string Name { get; set; }
        public virtual IList<VehiclePart> Parts { get; } = new List<VehiclePart>();
    }
}