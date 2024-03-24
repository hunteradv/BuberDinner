﻿namespace BuberDinner.Domain.Common.Models
{
    public abstract class Entity<TId> : IEquatable<Entity<TId>>
    where TId : notnull
    {
        protected Entity(TId id)
        {
            Id = id;
        }

        public TId Id { get; protected set; }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Entity<TId>)obj);
        }

        public static bool operator ==(Entity<TId> left, Entity<TId> right)
        {
            return Equals(left, right);
        }
        
        public static bool operator !=(Entity<TId> left, Entity<TId> right)
        {
            return !Equals(left, right);
        }

        public bool Equals(Entity<TId>? other)
        {
            return Equals((object?) other);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<TId>.Default.GetHashCode(Id);
        }
    }
}
