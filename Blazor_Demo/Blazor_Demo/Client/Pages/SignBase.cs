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
    public class SignBase : ComponentBase
    {
        protected User User { get; set; } = new User();
        protected EditContext EditContext { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            EditContext = new EditContext(User);
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
