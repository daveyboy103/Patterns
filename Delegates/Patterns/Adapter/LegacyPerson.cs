namespace Delegates.Patterns.Adapter
{
    public class LegacyPerson
    {
        public string FullName { get; init; }
        public string Sex { get; init; }

        public override string ToString()
        {
            return $"{FullName} - {Sex} | {GetType().FullName}";
        }
    }
}