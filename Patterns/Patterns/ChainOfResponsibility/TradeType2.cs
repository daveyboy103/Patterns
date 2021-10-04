namespace Delegates.Patterns.ChainOfResponsibility
{
    public class TradeType2 : ITradeType
    {
        public string Type { get; set; }
        public override string ToString()
        {
            return $"I'm Trade Type 2:{Type} ";
        }
    }
}