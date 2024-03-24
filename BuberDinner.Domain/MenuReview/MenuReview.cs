using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.MenuReview.ValueObjects;

namespace BuberDinner.Domain.MenuReview
{
    internal class MenuReview : AggregateRoot<MenuReviewId>
    {
        public MenuReview(MenuReviewId id) : base(id)
        {
        }
    }
}
