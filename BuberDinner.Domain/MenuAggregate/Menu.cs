using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Common.ValueObjects;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Menu.ValueObjects;
using BuberDinner.Domain.MenuAggregate.Entities;
using BuberDinner.Domain.MenuAggregate.ValueObjects;
using BuberDinner.Domain.MenuReview.ValueObjects;

namespace BuberDinner.Domain.MenuAggregate
{
    public sealed class Menu : AggregateRoot<MenuId, Guid>
    {
        //EF
        private Menu()
        {
        }

        public Menu(MenuId id, string name, string description, List<MenuSection> sections, HostId hostId) : base(id)
        {
            _sections = sections;
            HostId = hostId;
            Name = name;
            Description = description;
        }

        private readonly List<MenuSection> _sections = new();
        private readonly List<DinnerId> _dinnerIds = new();
        private readonly List<MenuReviewId> _menuReviewIds = new();

        public string Name { get; private set; }
        public string Description { get; private set; }
        public AverageRating? AverageRating { get; private set; }
        public HostId HostId { get; private set; }

        public IReadOnlyCollection<MenuSection> Sections => _sections.AsReadOnly();
        public IReadOnlyCollection<DinnerId> DinnerIds => _dinnerIds.AsReadOnly();
        public IReadOnlyCollection<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();
        public DateTime CreatedDateTime { get; private set; }
        public DateTime UpdatedDateTime { get; private set; }

        public static Menu Create(HostId hostId, string name, string description, List<MenuSection>? sections)
        {
            return new Menu(MenuId.CreateUnique(), name, description, sections, hostId);
        }
    }
}
