namespace Delegates.Patterns.Prototype
{
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
}