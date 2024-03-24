﻿using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Domain.User;

namespace BuberDinner.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();
    
    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(x => x.Email == email);
    }

    public void Add(User user)
    {
        _users.Add(user);
    }
}