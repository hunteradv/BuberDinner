namespace BuberDinner.Domain.Common.Models
{
    public class AggregateRoot<TId, TIdType> : Entity<TId>
    where TId : AggregateRootId<TIdType>
    {
        //EF
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        protected AggregateRoot()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        public new AggregateRootId<TIdType> Id { get; protected set; }

        public AggregateRoot(TId id)
        {
            Id = id;
        }
    }
}
