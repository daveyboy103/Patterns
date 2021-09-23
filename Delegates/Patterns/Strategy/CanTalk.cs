namespace Delegates.Patterns.Strategy
{
    public class CanTalk : ITalking
    {
        public string Action()
        {
            return "I can talk!";
        }
    }
}