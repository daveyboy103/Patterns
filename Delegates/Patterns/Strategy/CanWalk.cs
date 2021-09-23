namespace Delegates.Patterns.Strategy
{
    public class CanWalk : IWalking
    {
        public string Action()
        {
            return "I can walk!";
        }
    }
}