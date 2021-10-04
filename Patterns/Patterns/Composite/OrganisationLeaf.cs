using System;
using System.Collections.Generic;

namespace Delegates.Patterns.Composite
{
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