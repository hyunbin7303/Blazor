using Blazor_Demo.Shared.Contracts;
using Blazor_Demo.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Demo.TestFake
{
    public class UserManagerFake : IUserManager
    {
        public Task InsertUserAsync(User user)
        {
            return Task.FromResult(true);
        }

        public Task<User> TrySignInAndGetUserAsync(User user)
        {
            return Task.FromResult(new User());
        }
    }
}
