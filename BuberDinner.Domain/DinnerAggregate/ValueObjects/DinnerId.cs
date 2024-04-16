using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.DinnerAggregate.ValueObjects
{
    public class DinnerId : AggregateRootId<Guid>

    {
        public DinnerId(Guid value)
        {
            Value = value;
        }

        public sealed override Guid Value { get; protected set; }

        public static DinnerId CreateUnique()
        {
            return new DinnerId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
