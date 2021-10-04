namespace Delegates.Patterns.Vistor
{
    public interface IVisitor
    {
        double Visit(IVisitable target);
    }
}