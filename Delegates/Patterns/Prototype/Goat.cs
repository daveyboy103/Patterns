namespace Delegates.Patterns.Prototype
{
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