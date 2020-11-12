using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.Controls
{
    public class ValidationInputBase : ComponentBase
    {
        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }
            
        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public string Error { get; set; }


        protected async void HandleInputChanged(ChangeEventArgs args)
        {
            await ValueChanged.InvokeAsync(args.Value.ToString());
        }
    }
}
