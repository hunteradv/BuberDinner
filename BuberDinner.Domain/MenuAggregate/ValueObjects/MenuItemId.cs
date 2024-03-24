using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public class MenuItemId : ValueObject
    {
        public MenuItemId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static MenuItemId CreateUnique()
        {
            return new MenuItemId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
