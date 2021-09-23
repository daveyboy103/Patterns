namespace Delegates.Patterns.Strategy
{
    public class CannotWalk : IWalking
    {
        public string Action()
        {
            return "I cannot walk!";
        }
    }
}