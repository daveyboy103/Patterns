namespace Delegates.Patterns.State
{
    public class OutOfMoneyState : IStateBehaviour
    {
        public string EnterPin(IStateBehaviourImpl state, int pin)
        {
            return "Out of service";
        }

        public string WithdrawCard(IStateBehaviourImpl state)
        {
            return "Eject card";
        }

        public string RequestCash(IStateBehaviourImpl state, int howMuch)
        {
            return "Out of service";
        }

        public string InsertCard(IStateBehaviourImpl state)
        {
            return "Out of service";
        }
        
        public void Reset() { }
    }
}