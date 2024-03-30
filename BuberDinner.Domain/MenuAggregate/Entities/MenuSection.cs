using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;

namespace BuberDinner.Domain.Menu.Entities
{
    public sealed class MenuSection : Entity<MenuSectionId>
    {
        public MenuSection(MenuSectionId id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;
        }

        private readonly List<MenuItem> _items = new ();
        public string Name { get; private set; }
        public string Description { get; private set; }

        public IReadOnlyList<MenuItem> Items => _items.AsReadOnly();

        public static MenuSection Create(string name, string description, IEnumerable<MenuItem> menuItems)
        {
            return new MenuSection(MenuSectionId.CreateUnique(), name, description);
        }
    }
}
