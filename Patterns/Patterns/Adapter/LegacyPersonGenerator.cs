namespace Delegates.Patterns.Adapter
{
    public class LegacyPersonGenerator : IPersonGenerator, ILegacyPersonRetriever
    {
        private LegacyPerson _legacyPerson;
        
        public IPerson Create(string firstName, string lastName, Gender gender)
        {
            _legacyPerson = new LegacyPerson()
            {
                FullName = $"{firstName} {lastName}",
                Sex = gender.ToString()
            };

            return null;
        }

        public LegacyPerson Get()
        {
            return _legacyPerson;
        }
    }
}