using System.Collections.Generic;
using System.Xml;

namespace Delegates.Patterns.State
{
    public static class StateBehaviourFactory
    {
        private static readonly IDictionary<StateBehaviourType, IStateBehaviour> StatesCache = new Dictionary<StateBehaviourType, IStateBehaviour>();
        private static readonly object Locker = new object();

        public static IStateBehaviour Get(StateBehaviourType type)
        {
            IStateBehaviour ret = new NoCardState();
            bool noCache = false;

            lock (Locker)
            {
                if (StatesCache.ContainsKey(type) )
                {
                    return StatesCache[type];
                }

                switch (type)
                {
                    case StateBehaviourType.NoCard:
                        ret = new NoCardState();
                        break;
                    case StateBehaviourType.CardAccepted:
                        ret = new CardAcceptedState();
                        break;
                    case StateBehaviourType.CardInserted:
                        ret = new CardInsertedState();
                        noCache = true;
                        break;
                    case StateBehaviourType.OutOfMoney:
                        ret = new OutOfMoneyState();
                        break;
                }
                
                if(!noCache)
                    StatesCache.Add(type, ret);
            }
            
            return ret;
        }
    }
}