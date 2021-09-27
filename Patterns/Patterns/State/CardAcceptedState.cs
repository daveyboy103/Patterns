namespace Delegates.Patterns.State
{
    public class CardAcceptedState : IStateBehaviour
    {
        public string EnterPin(IStateBehaviourImpl stat, int pin)
        {
            return "Pin already accepted";
        }

        public string WithdrawCard(IStateBehaviourImpl stat)
        {
            stat.State = StateBehaviourFactory.Get(StateBehaviourType.NoCard);
            return "Card ejected";
        }

        public string RequestCash(IStateBehaviourImpl stat, int howMuch)
        {
            if (stat.State is CardAcceptedState)
            {
                if (stat.State is OutOfMoneyState)
                    return "Out of funds";
                return "Take the money";
            }
            return "Insert card and enter pin";
        }

        public string InsertCard(IStateBehaviourImpl state)
        {
            if (state is NoCardState)
            {
                state.State = new CardInsertedState();
                return "Card inserted";
            }

            return "Meh!";
        }
        
        public void Reset() { }
    }
}