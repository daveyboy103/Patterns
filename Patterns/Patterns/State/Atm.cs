namespace Delegates.Patterns.State
{
    public class Atm : IStateBehaviourImpl
    {
        private IStateBehaviour _stateBehaviour;
        public Atm()
        {
            _stateBehaviour = StateBehaviourFactory.Get(StateBehaviourType.NoCard);
        }
        
        public string EnterPin(int pin)
        {
            return _stateBehaviour.EnterPin(this, pin);
        }

        public string WithdrawCard()
        {
            return _stateBehaviour.WithdrawCard(this);
        }

        public string RequestCash(int amount)
        {
            return _stateBehaviour.RequestCash(this, amount);
        }

        public string InsertCard()
        {
            return _stateBehaviour.InsertCard(this);
        }

        public IStateBehaviour State
        {
            get => _stateBehaviour;
            set => _stateBehaviour = value;
        }
    }
}