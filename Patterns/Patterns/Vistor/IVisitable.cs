namespace Delegates.Patterns.Vistor
{
    public interface IVisitable
    {
        double Accept(IVisitor visitor);
        double Value { get; set; }
        public double Duty { get; set; }
    }
}