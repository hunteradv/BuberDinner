using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public class HostId : ValueObject
    {
        public HostId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static HostId CreateUnique()
        {
            return new HostId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static HostId Create(string value)
        {
            return new HostId(Guid.Parse(value));
        }
    }
}
