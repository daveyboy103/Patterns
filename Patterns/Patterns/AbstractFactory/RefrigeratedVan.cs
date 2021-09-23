using System;
using System.Collections.Generic;

namespace Delegates.Patterns.AbstractFactory
{
    public class RefrigeratedVan : Van
    {
        private readonly Van _baseVan;
        
        public RefrigeratedVan(Van baseVan)
        {
            _baseVan = baseVan ?? throw new ArgumentNullException(nameof(baseVan));

            Name = "Refrigerated Van";
            
            Parts.Add(new FreezerPlant());
        }

        public sealed override IList<VehiclePart> Parts => _baseVan.Parts;
    }
}