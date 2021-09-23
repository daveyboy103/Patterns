using System.Collections.Generic;

namespace Delegates.Patterns.AbstractFactory
{
    public abstract class Vehicle
    {
        protected string Name { get; set; }
        public virtual IList<VehiclePart> Parts { get; } = new List<VehiclePart>();
    }
}