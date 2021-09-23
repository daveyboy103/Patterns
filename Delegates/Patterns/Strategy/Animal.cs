namespace Delegates.Patterns.Strategy
{
    public abstract class Animal
    {
        public string Name { get; init; }
        
        public IWalking WalkingBehaviour { get; set; }
        public ITalking TalkingBehaviour { get; set; }
        public IFlying FlyingBehaviour { get; set; }
    }
}