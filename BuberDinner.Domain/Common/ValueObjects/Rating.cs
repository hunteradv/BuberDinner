using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Common.ValueObjects
{
    public class Rating : ValueObject

    {
        public Rating(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }

        public override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
