using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.UserAggregate.ValueObjects;

namespace BuberDinner.Domain.MenuAggregate.ValueObjects
{
    public class HostId : ValueObject
    {
        public HostId(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static HostId CreateUnique(UserId userId)
        {
            return new HostId($"Host_{userId.Value}");
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static HostId Create(string value)
        {
            return new HostId(value);
        }
    }
}
