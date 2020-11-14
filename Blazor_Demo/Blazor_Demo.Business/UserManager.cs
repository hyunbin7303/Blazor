using Blazor_Demo.Shared.Entities;
using System.Threading.Tasks;

namespace Blazor_Demo.Business
{
    public class UserManager
    {
        public async Task<User> TrySignInAndGetUserAsync(User user)
        {
            await Task.Delay(10000);

            return await Task.FromResult(new User());
        }
        public async Task InsertUserAsync(User user)
        {
            await Task.FromResult(user);
        }
    }
}
