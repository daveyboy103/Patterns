using System.Collections.Generic;
using System.Linq;

namespace Delegates.Patterns.Composite
{
    public class Organisation : IOrganisationUnit
    {
        public string Name { get; init; }
        public virtual IEnumerable<IOrganisationUnit> OrganisationUnits { get; } = new List<IOrganisationUnit>();
        public virtual void AddNew(Organisation organisation)
        {
            var organisationUnits = ((List<IOrganisationUnit>)OrganisationUnits);
            if(organisationUnits.All(x => x.Name == organisation.Name))
            {
                organisationUnits.Add(organisation);
            }
        }
    }
}