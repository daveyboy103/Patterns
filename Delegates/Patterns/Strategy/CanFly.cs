namespace Delegates.Patterns.Strategy
{
    public class CanFly : IFlying
    {
        public string Action()
        {
            return "I can fly!";
        }
    }
}