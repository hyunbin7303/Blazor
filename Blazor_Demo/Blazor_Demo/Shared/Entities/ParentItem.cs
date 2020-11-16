using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blazor_Demo.Shared.Entities
{
    public class ParentItem : BaseEntity
    {
        public ObservableCollection<ChildItem> ChildItems { get; set; }
    }
}
