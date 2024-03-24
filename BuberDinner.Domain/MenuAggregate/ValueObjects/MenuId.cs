using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public class MenuId : ValueObject
    {
        public MenuId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static MenuId CreateUnique()
        {
            return new MenuId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
