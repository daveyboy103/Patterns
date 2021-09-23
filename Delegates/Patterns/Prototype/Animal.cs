using System;

namespace Delegates.Patterns.Prototype
{
    public class PrototypeOrchestrator
    {
        public Animal GetClone(Animal animal)
        {
            return (Animal) animal.Clone();
        }
    }
    
    public interface Animal : ICloneable
    {
        string Name { get; set; }
    }

    public class Sheep : Animal
    {
        public Sheep()
        {
            Name = "Sheepy";
        }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string Name { get; set; }
    }
    
    public class Goat : Animal
    {
        public Goat()
        {
            Name = "Greatest of all time";
        }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string Name { get; set; }
    }
}