namespace Delegates.Patterns.Adapter
{
    public class NewPersonGenerator : IPersonGenerator
    {
        public IPerson Create(string firstName, string lastName, Gender gender)
        {
            var ret = NewPerson.Create();

            ret.FirstName = firstName;
            ret.LastName = lastName;
            ret.Gender = gender;

            return ret;
        }
    }
}