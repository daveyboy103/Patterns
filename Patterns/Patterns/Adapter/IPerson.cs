namespace Delegates.Patterns.Adapter
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Gender Gender { get; set; }
    }
}