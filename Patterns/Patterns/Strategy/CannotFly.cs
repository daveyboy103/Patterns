namespace Delegates.Patterns.Strategy
{
    public class CannotFly : IFlying
    {
        public string Action()
        {
            return "I cannot fly!";
        }
    }
}