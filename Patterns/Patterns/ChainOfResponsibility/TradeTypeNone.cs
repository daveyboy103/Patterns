namespace Delegates.Patterns.ChainOfResponsibility
{
    public class TradeTypeNone : ITradeType
    {
        public string Type { get; set; }
        public override string ToString()
        {
            return $"I'm Trade Type 1:{Type} ";
        }
    }
}