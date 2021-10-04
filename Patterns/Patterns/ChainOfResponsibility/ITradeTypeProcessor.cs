namespace Delegates.Patterns.ChainOfResponsibility
{
    public interface ITradeTypeProcessor
    {
        ITradeType Process(ITradeType subject);
        ITradeTypeProcessor NextProcessor { get; init; }
    }
}