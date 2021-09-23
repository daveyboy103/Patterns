using System;

namespace Delegates.Patterns.Prototype
{
    public interface Animal : ICloneable
    {
        string Name { get; set; }
    }
}