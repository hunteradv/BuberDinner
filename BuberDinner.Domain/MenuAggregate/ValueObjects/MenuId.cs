using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.MenuAggregate.ValueObjects
{
    public class MenuId : AggregateRootId<Guid>
    {
        public MenuId(Guid value)
        {
            Value = value;
        }

        public sealed override Guid Value { get; protected set; }

        public static MenuId CreateUnique()
        {
            return new MenuId(Guid.NewGuid());
        }

        public static MenuId Create(Guid id)
        {
            return new MenuId(id);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
