using Blazor_Demo.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor_Demo.Shared.Entities
{
    public class BaseItem : BaseEntity
    {
        public int ParentId { get; set; }
        public ItemTypeEnum ItemTypeEnum { get; set; }
        public int Position { get; set; }
        public bool IsDone { get; set; }
        public string Title { get; set; }

    }
}
