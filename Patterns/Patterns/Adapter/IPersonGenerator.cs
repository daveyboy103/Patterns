namespace Delegates.Patterns.Adapter
{
    public interface IPersonGenerator
    {
        IPerson Create(string firstName, string lastName, Gender gender);
    }
}