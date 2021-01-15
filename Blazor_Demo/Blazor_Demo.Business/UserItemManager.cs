using Blazor_Demo.Shared.Contracts;
using Blazor_Demo.Shared.Entities;
using Blazor_Demo.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Demo.Business
{
    public class UserItemManager : IUserItemManager
    {
        public async Task<ChildItem> CreateNewChildItemAndAddItToParentItemAsync(ParentItem parent)
        {
            var childItem = new ChildItem();
            childItem.ParentId = parent.Id;
            childItem.ItemTypeEnum = ItemTypeEnum.Child;

            parent.ChildItems.Add(childItem);
            return await Task.FromResult(childItem);
        }
    }
}
