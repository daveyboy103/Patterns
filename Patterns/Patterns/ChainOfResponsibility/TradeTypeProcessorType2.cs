using System;

namespace Delegates.Patterns.ChainOfResponsibility
{
    public class TradeTypeProcessorType2 : ITradeTypeProcessor
    {
        public ITradeType Process(ITradeType subject)
        {
            if (subject.GetType() == typeof(TradeType2))
            {
                subject.Type = "Caught Type 2 ";
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