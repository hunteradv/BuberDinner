using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.MenuReviewAggregate.ValueObjects
{
    public class MenuReviewId : AggregateRootId<Guid>

    {
        public MenuReviewId(Guid value)
        {
            Value = value;
        }

        public sealed override Guid Value { get; protected set; }

        public static MenuReviewId CreateUnique()
        {
            return new MenuReviewId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
