using Blazor_Demo.Business;
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


        protected async void OnSubmit()
        {
            if(EditContext.Validate())
            {
                return;
            }
            UserManager userManager = new UserManager();
            var userExist = await userManager.TrySignInAndGetUserAsync(User);
            if(userExist != null)
            {
                NavigationManager.NavigateTo("items");
            }
        }
    }
}
