using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;

namespace BuberDinner.Domain.DinnerAggregate
{
    public class Dinner : AggregateRoot<DinnerId, Guid>
    {
        //EFT
        private Dinner()
        {
        }

        public Dinner(DinnerId id) : base(id)
        {
        }
    }
}
