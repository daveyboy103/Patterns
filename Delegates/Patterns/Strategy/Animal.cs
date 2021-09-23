namespace Delegates.Patterns.Strategy
{
    public abstract class Animal
    {
        public string Name { get; init; }
        
        public IWalking WalkingBehaviour { get; set; }
        public ITalking TalkingBehaviour { get; set; }
        public IFlying FlyingBehaviour { get; set; }
    }

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

    public class Parrot : Bird
    {
        public Parrot()
        {
            Name = "Parrot";
            TalkingBehaviour = new CanTalk();
        }
    }

    public interface IWalking
    {
        public string Action();
    }

    public class CanWalk : IWalking
    {
        public string Action()
        {
            return "I can walk!";
        }
    }
    
    public class CannotWalk : IWalking
    {
        public string Action()
        {
            return "I cannot walk!";
        }
    }
    
    public interface ITalking
    {
        public string Action();
    }

    public class CanTalk : ITalking
    {
        public string Action()
        {
            return "I can talk!";
        }
    }

    public class CannotTalk : ITalking
    {
        public string Action()
        {
            return "I cannot talk!";
        }
    }
    
    public interface IFlying
    {
        public string Action();
    }

    public class CannotFly : IFlying
    {
        public string Action()
        {
            return "I cannot fly!";
        }
    }
    
    public class CanFly : IFlying
    {
        public string Action()
        {
            return "I can fly!";
        }
    }
}