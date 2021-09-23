using System.Collections.Generic;
using System.Linq;

namespace Delegates.Patterns.AbstractFactory
{
    public class VanFactory : VehicleFactory
    {
        private IList<PartsFactory> _partsFactories;
        
        public override Vehicle Build(IEnumerable<PartsFactory> partsFactories = null)
        {
            if (partsFactories == null)
            {
                _partsFactories = new List<PartsFactory> {new VanPartsFactory()};
            }
            else
            {
                _partsFactories = partsFactories.ToList();
            }

            var ret = new Van();

            foreach (var partsFactory in _partsFactories)
            {
                foreach (var vehiclePart in partsFactory.GetParts())
                {
                    ret.Parts.Add(vehiclePart);
                }
            }

            return ret;
        }
    }

    public class VanPartsFactory : PartsFactory
    {
        public override IEnumerable<VehiclePart> GetParts()
        {
            var ret = new List<VehiclePart>();
            ret.Add(new SteeringWheel());
            ret.Add(new Windscreen());
            
            return ret;
        }
    }

    public class SteeringWheel : VehiclePart
    {
        public SteeringWheel()
        {
            Name = "Steering Wheel";
        }
    }

    public class FreezerPlant : VehiclePart
    {
        public FreezerPlant()
        {
            Name = "Freezer Plant";
        }
    }
    public class Windscreen : VehiclePart
    {
        public Windscreen()
        {
            Name = "Windscreen";
        }
    }
}