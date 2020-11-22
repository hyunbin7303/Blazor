using Blazor_Demo.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.Components
{
    public partial class ItemElement<Titem> : ComponentBase where Titem : BaseItem
    {
        [Parameter]
        public Titem Item { get; set; }
    }
}
