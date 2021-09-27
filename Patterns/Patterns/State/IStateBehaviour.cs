namespace Delegates.Patterns.State
{
    public interface IStateBehaviour
    {
        public string EnterPin(IStateBehaviourImpl state, int pin);
        public string WithdrawCard(IStateBehaviourImpl state);
        public string RequestCash(IStateBehaviourImpl stat, int howMuch);
        public string InsertCard(IStateBehaviourImpl stat);

        public void Reset();
    }
}