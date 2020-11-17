using Blazor_Demo.Shared.Contracts;
using Blazor_Demo.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor_Demo.Business
{
    public class CurrentUserService : ICurrentUserService
    {
        public User CurrentUser { get; set; }
    }
}
