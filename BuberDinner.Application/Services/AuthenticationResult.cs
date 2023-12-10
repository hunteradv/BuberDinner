using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuberDinner.Domain;

namespace BuberDinner.Application.Services
{
    public record AuthenticationResult(User User, string Token);
}
