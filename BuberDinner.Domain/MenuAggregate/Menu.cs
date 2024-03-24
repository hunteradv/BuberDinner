using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Menu.Entities;
using BuberDinner.Domain.Menu.ValueObjects;
using BuberDinner.Domain.MenuReview.ValueObjects;

namespace BuberDinner.Domain.Menu
{
    public sealed class Menu : AggregateRoot<MenuId>
    {
        public Menu(MenuId id, string description, float averageRating) : base(id)
        {
            Description = description;
            AverageRating = averageRating;
        }

        private readonly List<MenuSection> _sections = new();
        private readonly List<DinnerId> _dinnerIds = new();
        private readonly List<MenuReviewId> _menuReviewIds = new();

        public string Name { get; }
        public string Description { get; }
        public float AverageRating { get; }
        public HostId HostId { get;  }

        public IReadOnlyCollection<MenuSection> Sections => _sections.AsReadOnly();
        public IReadOnlyCollection<DinnerId> DinnerIds => _dinnerIds.AsReadOnly();
        public IReadOnlyCollection<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }
    }
}
