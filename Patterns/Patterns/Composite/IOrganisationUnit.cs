using System;
using System.Collections.Generic;

namespace Delegates.Patterns.Composite
{
    public interface IOrganisationUnit
    {
        public String Name { get; init; }
        public IEnumerable<IOrganisationUnit> OrganisationUnits { get; }
        void AddNew(Organisation organisation);
    }
}