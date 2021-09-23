namespace Delegates.Patterns.Strategy
{
    public class Parrot : Bird
    {
        public Parrot()
        {
            Name = "Parrot";
            TalkingBehaviour = new CanTalk();
        }
    }
}