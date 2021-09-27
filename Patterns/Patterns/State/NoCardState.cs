namespace Delegates.Patterns.State
{
    public class NoCardState : IStateBehaviour
    {
        public string EnterPin(IStateBehaviourImpl state, int pin)
        {
            return "Please insert card";
        }

        public string WithdrawCard(IStateBehaviourImpl state)
        {
            return "No card inserted";
        }

        public string RequestCash(IStateBehaviourImpl state, int howMuch)
        {
            return "Insert card and enter PIN";
        }

        public string InsertCard(IStateBehaviourImpl state)
        {
            state.State = StateBehaviourFactory.Get(StateBehaviourType.CardInserted);
            return "Card inserted";
        }

        public void Reset() { }
    }
}