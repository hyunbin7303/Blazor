using Blazor_Demo.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.Components
{
    public class ItemCheckBoxBase : ComponentBase
    {
        [Parameter]
        public BaseItem Item { get; set; }

        [CascadingParameter]
        public string ColorPrefix { get; set; }
    }
}
