using Blazor_Demo.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Demo.Shared.Contracts
{
    public interface IUserItemManager
    {
        Task<ChildItem> CreateNewChildItemAndAddItToParentItemAsync(ParentItem parent);
    }
}
