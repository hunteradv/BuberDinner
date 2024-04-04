using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Common.ValueObjects;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Menu.ValueObjects;
using BuberDinner.Domain.MenuAggregate.Entities;
using BuberDinner.Domain.MenuReview.ValueObjects;

namespace BuberDinner.Domain.MenuAggregate
{
    public sealed class Menu : AggregateRoot<MenuId>
    {
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

        public string Name { get; }
        public string Description { get; }
        public AverageRating AverageRating { get; }
        public HostId HostId { get;  }

        public IReadOnlyCollection<MenuSection> Sections => _sections.AsReadOnly();
        public IReadOnlyCollection<DinnerId> DinnerIds => _dinnerIds.AsReadOnly();
        public IReadOnlyCollection<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }

        public static Menu Create(HostId hostId, string name, string description, List<MenuSection>? sections)
        {
            return new Menu(MenuId.CreateUnique(), name, description, sections, hostId);
        }
    }
}
