namespace Delegates.Patterns.State
{
    public interface IStateBehaviourImpl
    {
        public string EnterPin(int pin);
        public string WithdrawCard();
        public string RequestCash(int howMuch);
        public string InsertCard();
        public IStateBehaviour State { get; set; }
    }
}