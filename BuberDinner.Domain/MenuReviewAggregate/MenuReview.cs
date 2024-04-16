using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.MenuReviewAggregate.ValueObjects;

namespace BuberDinner.Domain.MenuReview
{
    internal class MenuReview : AggregateRoot<MenuReviewId, Guid>
    {
        public MenuReview(MenuReviewId id) : base(id)
        {
        }
    }
}
