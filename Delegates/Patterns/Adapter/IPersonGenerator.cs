namespace Delegates.Patterns.Adapter
{
    public interface IPersonGenerator
    {
        IPerson Create(string firstName, string lastName, Gender gender);
    }

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

    public interface ILegacyPersonRetriever
    {
        LegacyPerson Get();
    }

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

    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        PreferNoToSay
    }

    public class NewPerson : IPerson
    {
        private NewPerson(){
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }

        public static IPerson Create()
        {
            return new NewPerson();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Gender} | {GetType().FullName}";
        }
    }

    public class LegacyPerson
    {
        public string FullName { get; init; }
        public string Sex { get; init; }

        public override string ToString()
        {
            return $"{FullName} - {Sex} | {GetType().FullName}";
        }
    }

    public class LegacyPersonAdapter : IPerson
    {
        private LegacyPerson _legacyPerson = new LegacyPerson();
        
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public Gender Gender { get; set; }
    }
}