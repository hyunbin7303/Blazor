using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blazor_Demo.Shared.Entities
{
    public class ParentItem : BaseItem
    {
        public ObservableCollection<ChildItem> ChildItems { get; set; }
    }
}
