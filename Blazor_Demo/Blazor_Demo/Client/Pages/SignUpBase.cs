using Blazor_Demo.Shared.Enums;
using GeneralUI.DropdownControl;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.Pages
{
    public class SignUpBase : SignBase
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }
        protected IList<DropdownItem<GenderTypeEnum>> GenderTypeDropdownItems { get; } = new List<DropdownItem<GenderTypeEnum>>();
        protected DropdownItem<GenderTypeEnum> SelectedGenderTypeDropdownItem { get; set; }
        
        
        [Parameter]
        public string Username { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            var male = new DropdownItem<GenderTypeEnum>
            {
                ItemObject = GenderTypeEnum.Male,
                DisplayText ="Male"
            };
            var female = new DropdownItem<GenderTypeEnum>
            {
                ItemObject = GenderTypeEnum.Female,
                DisplayText = "Female"
            };
            var netural = new DropdownItem<GenderTypeEnum>
            {
                ItemObject = GenderTypeEnum.Neutral,
                DisplayText = "others"
            };

            GenderTypeDropdownItems.Add(male);
            GenderTypeDropdownItems.Add(female);
            GenderTypeDropdownItems.Add(netural);
            SelectedGenderTypeDropdownItem = female;

            TryGetUsernameFromUri();
            //User.UserName = Username;

        }

        private void TryGetUsernameFromUri()
        {
            var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
            StringValues sv;
            if(QueryHelpers.ParseQuery(uri.Query).TryGetValue("userName", out sv))
            {
                User.UserName = sv;

            }
        }

        protected void OnValidSubmit()
        {
            NavigationManager.NavigateTo("signin");
        }

    }
}
