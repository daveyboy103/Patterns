namespace Delegates.Patterns.Adapter
{
    public class LegacyPersonAdapter : IPerson
    {
        private LegacyPerson _legacyPerson = new LegacyPerson();
        
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public Gender Gender { get; set; }
    }
}