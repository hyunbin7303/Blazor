using Blazor_Demo.Shared.Contracts;
using Blazor_Demo.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.Pages
{
    public class SignInBase : SignBase
    {
        protected string Day { get; } = DateTime.Now.DayOfWeek.ToString();

        [Inject]
        private NavigationManager NavigationManager { get; set; }
        [Inject]
        private IUserManager UserManager { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            User = new User
            {
                FirstName = "X",
                LastName = "X",
                PhoneNumber = "123"
            };

            EditContext = new EditContext(User);
        }


        protected async void OnSubmit()
        {
            if(EditContext.Validate())
            {
                return;
            }
            Console.WriteLine($"Signin User :{User.UserName}, {User.FirstName}");
            var userExist = await UserManager.TrySignInAndGetUserAsync(User);
            if(userExist != null)
            {
                NavigationManager.NavigateTo("items");
            }
        }
    }
}
