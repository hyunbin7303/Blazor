using Blazor_Demo.Client.ItemEdit;
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
        public RenderFragment MainFragment { get; set; }


        [Parameter]
        public RenderFragment DetailFragment { get; set; }

        [Parameter]
        public Titem Item { get; set; }
        

        [CascadingParameter]
        public string ColorPrefix { get; set; }


        [CascadingParameter]
        public int TotalNumber { get; set; }


        [Inject]
        private ItemEditService ItemEditService { get; set; }
    
        private string DetailAreaId { get; set; }
        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            DetailAreaId = "detailArea" + Item.Position;
        }

        private void OpenItemInEditMode()
        {
            ItemEditService.EditItem = Item;
        }


    }
}
