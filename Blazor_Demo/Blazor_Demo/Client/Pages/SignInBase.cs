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
    public class SignInBase : ComponentBase
    {
        protected string Day { get; } = DateTime.Now.DayOfWeek.ToString();
        protected string Username { get; set; } = "Test";
        protected User User { get; set; } = new User();
        protected EditContext EditContext { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            EditContext = new EditContext(User);  
        }
        protected void HandleUserNameChanged(ChangeEventArgs eventArgs)
        {
            Username = eventArgs.Value.ToString();
        }
        protected void HandleUserNameValueChanged(string value)
        {
            Username = value;
        }
        public string GetError(Expression<Func<object>> fuc)
        {
            if(EditContext == null)
            {
                return null;
            }
            return EditContext.GetValidationMessages(fuc).FirstOrDefault(); 
        }
    }
}
