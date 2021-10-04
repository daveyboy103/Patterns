namespace Delegates.Patterns.Vistor
{
    public class FxTrade : IVisitable
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