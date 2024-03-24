﻿using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;

namespace BuberDinner.Domain.Menu.Entities
{
    public sealed class MenuItem : Entity<MenuItemId>
    {
        public MenuItem(MenuItemId id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }

        public static MenuItem Create(string name, string description)
        {
            return new MenuItem(MenuItemId.CreateUnique(), name, description);
        }
    }
}
