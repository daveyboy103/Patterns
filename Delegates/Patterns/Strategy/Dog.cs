namespace Delegates.Patterns.Strategy
{
    public class Dog : Animal
    {
        public Dog()
        {
            Name = "Dog";
            TalkingBehaviour = new CannotTalk();
            WalkingBehaviour = new CanWalk();
            FlyingBehaviour = new CannotFly();
        }
    }
}