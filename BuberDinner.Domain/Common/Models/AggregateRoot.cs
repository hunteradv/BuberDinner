﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Common.Models
{
    public class AggregateRoot<TId> : Entity<TId>
    where TId : notnull
    {
        public AggregateRoot(TId id) : base(id)
        {
        }
    }
}
