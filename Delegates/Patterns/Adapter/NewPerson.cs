namespace Delegates.Patterns.Adapter
{
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
}