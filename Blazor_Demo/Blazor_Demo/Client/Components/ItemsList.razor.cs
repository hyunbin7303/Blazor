using Blazor_Demo.Shared.Contracts;
using Blazor_Demo.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace Blazor_Demo.Client.Components
{
    public partial class ItemsList : ComponentBase
    {
        [Inject]
        private ICurrentUserService CurrentUserService { get; set; }
        protected ObservableCollection<BaseItem> UserItems { get; set; } = new ObservableCollection<BaseItem>();

        protected override void OnInitialized()
        {
            base.OnInitialized();
            UserItems = CurrentUserService.CurrentUser.UserItems;
            System.Console.WriteLine(UserItems.Count);
            System.Console.WriteLine(JsonSerializer.Serialize(UserItems));
        }
    }
}
