using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates.Patterns.Composite
{
    public interface IOrganisationUnit
    {
        public String Name { get; init; }
        public IEnumerable<IOrganisationUnit> OrganisationUnits { get; }
        void AddNew(Organisation organisation);
    }

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

    public class OrganisationLeaf : Organisation
    {
        public override IEnumerable<IOrganisationUnit> OrganisationUnits
        {
            get
            {
                throw new NotSupportedException("Leaf nodes cannot contain children");
            }
        }

        public override void AddNew(Organisation organisation)
        {
            throw new NotSupportedException("Not supported on laf nodes");
        }
    }
}