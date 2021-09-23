namespace Delegates.Patterns.Strategy
{
    public class CannotTalk : ITalking
    {
        public string Action()
        {
            return "I cannot talk!";
        }
    }
}