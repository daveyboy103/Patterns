using System;

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

    public static class PersonExtensions
    {
        public static IPerson ToPerson(this LegacyPerson subject)
        {
            var ret = NewPerson.Create();
            ret.FirstName = subject.FullName.Substring(0, subject.FullName.IndexOf(" ", StringComparison.Ordinal)).Trim();
            ret.LastName = subject.FullName.Substring(subject.FullName.IndexOf(" ", StringComparison.Ordinal)).Trim();
            ret.Gender = Enum.Parse<Gender>(subject.Sex);

            return ret;
        }
    }
}