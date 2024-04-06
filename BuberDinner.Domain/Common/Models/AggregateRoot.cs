namespace BuberDinner.Domain.Common.Models
{
    public class AggregateRoot<TId> : Entity<TId>
    where TId : notnull
    {
        //EF
        protected AggregateRoot()
        {
            
        }

        public AggregateRoot(TId id) : base(id)
        {
        }
    }
}
