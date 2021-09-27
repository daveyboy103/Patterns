namespace Delegates.Patterns.State
{
    public class CardInsertedState : IStateBehaviour
    {
        private bool _pinOK = false;
        public string EnterPin(IStateBehaviourImpl state, int pin)
        {
            if (pin == 123456)
            {
                state.State = new CardAcceptedState();
                _pinOK = true;
                return "Card inserted";
            }

            return "Incorrect PIN";
        }

        public string WithdrawCard(IStateBehaviourImpl state)
        {
            state.State = StateBehaviourFactory.Get(StateBehaviourType.NoCard);
            return "Card ejected";
        }

        public string RequestCash(IStateBehaviourImpl state, int howMuch)
        {
            if(_pinOK)
                if (state.State is OutOfMoneyState)
                    return "No money";
            return "Take the money";
        }

        public string InsertCard(IStateBehaviourImpl state)
        {
            if(_pinOK)
                return "Card already inserted and verified";
            return "Card already inserted, valid PIN required";
        }

        public void Reset()
        {
            _pinOK = false;
        }
    }
}