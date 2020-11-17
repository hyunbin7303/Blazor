using Blazor_Demo.Shared.Contracts;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.Shared
{
    public partial class MainLayout : LayoutComponentBase
    {


        [Inject]
        private ICurrentUserService CurrentUserService { get; set; }
        protected void SignOut()
        {

        }
    }
}
