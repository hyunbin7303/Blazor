using Blazor_Demo.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor_Demo.Shared.Contracts
{
    public interface ICurrentUserService
    {
        User CurrentUser { get; set; }
    }
}
