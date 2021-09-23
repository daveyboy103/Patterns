namespace Delegates.Patterns.Strategy
{
    public class Bird : Animal
    {
        protected internal Bird()
        {
            Name = "Bird";
            TalkingBehaviour = new CannotTalk();
            WalkingBehaviour = new CanWalk();
            FlyingBehaviour = new CanFly();
        }
    }
}