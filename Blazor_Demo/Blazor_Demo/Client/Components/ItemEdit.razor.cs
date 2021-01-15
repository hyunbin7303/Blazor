using Blazor_Demo.Business;
using Blazor_Demo.Client.ItemEdit;
using Blazor_Demo.Shared.Contracts;
using Blazor_Demo.Shared.Entities;
using Blazor_Demo.Shared.Enums;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.Components
{
    public partial class ItemEdit : ComponentBase, IDisposable
    {
        
        //[Inject]
        //private ItemEditService ItemEditService { get; set; }
        [Inject]
        private NavigationManager NavigationManager { get; set; }
        private BaseItem Item { get; set; } = new BaseItem();
        private int TotalNumber { get; set; }
        [Inject]
        private ICurrentUserService CurrentUserService { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            //ItemEditService.EditItemChanged += HandleEditItemChanged;
            //Item = ItemEditService.EditItem;
            SetDataFromUri();
        }

        private void SetDataFromUri()
        {
            var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            var segmentCount = uri.Segments.Length;
            if(segmentCount > 2 
                && Enum.TryParse(typeof(ItemTypeEnum),uri.Segments[segmentCount -2].Trim('/'), out var typeEnum) 
                && int.TryParse(uri.Segments[segmentCount -1], out var id))
            {
                var userItem = CurrentUserService.CurrentUser.
                        UserItems.
                        SingleOrDefault(item => item.ItemTypeEnum == (ItemTypeEnum)typeEnum && item.Id == id);

                if(userItem == null)
                {
                    NavigationManager.LocationChanged -= HandleLocationChanged;
                    NavigationManager.NavigateTo("/items");
                }   
                else
                {
                    NavigationManager.LocationChanged += HandleLocationChanged;
                    //StateHasChanged();
                }

            }

        }

        private void HandleLocationChanged(object sender, LocationChangedEventArgs e)
        {
            SetDataFromUri();
        }

        public void Dispose()
        {
            NavigationManager.LocationChanged -= HandleLocationChanged; 
        }

        //private void HandleEditItemChanged(object sender, ItemEditEventArgs e)
        //{
        //    Item = e.Item;
        //    StateHasChanged();
        //}

    }


}
