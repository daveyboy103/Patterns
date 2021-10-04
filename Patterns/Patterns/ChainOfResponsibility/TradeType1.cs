namespace Delegates.Patterns.ChainOfResponsibility
{
    public class TradeType1 : ITradeType
    {
        public string Type { get; set; }
        public override string ToString()
        {
            return $"I'm Trade Type 1:{Type} ";
        }
    }
}