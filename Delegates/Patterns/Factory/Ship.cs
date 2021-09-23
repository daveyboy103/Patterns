namespace Delegates.Patterns.Factory
{
    public abstract class Ship
    {
        public string Name { get; set; }
        protected IArmed ArmedStatus { get; set; }
    }
}