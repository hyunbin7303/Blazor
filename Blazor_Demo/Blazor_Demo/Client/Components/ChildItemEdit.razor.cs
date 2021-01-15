using Blazor_Demo.Shared.Contracts;
using Blazor_Demo.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.Components
{
    public partial class ChildItemEdit : ComponentBase
    {
        [Parameter]
        public ParentItem ParentItem { get; set; }

        [Inject]
        private IUserItemManager UserItemManager { get; set; }

        private async Task AddNewChildToParentAsync()
        {
            await  UserItemManager.CreateNewChildItemAndAddItToParentItemAsync(ParentItem);
        }
    }
}
