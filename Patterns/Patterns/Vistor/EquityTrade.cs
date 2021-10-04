namespace Delegates.Patterns.Vistor
{
    public class EquityTrade : IVisitable
    {
        public double Accept(IVisitor visitor)
        {
            // throw new System.NotImplementedException();
            return visitor.Visit(this);
        }

        public double Value { get; set; }
        public double Duty { get; set; }
    }
}