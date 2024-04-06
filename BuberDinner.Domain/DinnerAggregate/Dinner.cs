using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;

namespace BuberDinner.Domain.DinnerAggregate
{
    public class Dinner : AggregateRoot<DinnerId>
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
