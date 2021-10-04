using System;

namespace Delegates.Patterns.ChainOfResponsibility
{
    public class TradeTypeProcessorType1 : ITradeTypeProcessor
    {
        public ITradeType Process(ITradeType subject)
        {
            if (subject.GetType() == typeof(TradeType1))
            {
                subject.Type = "Caught Type1 ";
            }
            else
            {
                if (NextProcessor != null)
                {
                    subject = NextProcessor.Process(subject);
                }
                else
                    throw new NotImplementedException("No handler for type");
            }

            return subject;
        }

        public ITradeTypeProcessor NextProcessor { get; init; }
    }
}