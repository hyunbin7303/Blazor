using Blazor_Demo.Client.ItemEdit;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.Pages
{
    public partial class ItemsOverview : ComponentBase
    {
        [Inject]
        private ItemEditService ItemEditService { get; set; } 

        private bool ShowEdit { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            ItemEditService.EditItemChanged += HandleEditItemChanged;
        }


        private void HandleEditItemChanged(object sender, ItemEditEventArgs e)
        {
            ShowEdit = e.Item != null;
            StateHasChanged(); 
        }
    }
}
