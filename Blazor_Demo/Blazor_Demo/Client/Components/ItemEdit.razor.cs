﻿using Blazor_Demo.Client.ItemEdit;
using Blazor_Demo.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.Components
{
    public partial class ItemEdit
    {
        
        [Inject]
        private ItemEditService ItemEditService { get; set; }

        private BaseItem Item { get; set; } = new BaseItem();
        private int TotalNumber { get; set; }


        protected override void OnInitialized()
        {
            base.OnInitialized();
            ItemEditService.EditItemChanged += HandleEditItemChanged;
            Item = ItemEditService.EditItem;
        }
        private void HandleEditItemChanged(object sender, ItemEditEventArgs e)
        {
            Item = e.Item;
            StateHasChanged();
        }

    }


}
