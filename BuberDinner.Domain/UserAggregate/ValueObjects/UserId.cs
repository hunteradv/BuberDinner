using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.UserAggregate.ValueObjects
{
    public class UserId : ValueObject
    {
        public UserId(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static UserId CreateUnique()
        {
            return new UserId(Guid.NewGuid().ToString());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static UserId Create(string value)
        {
            return new UserId(value);
        }
    }
}