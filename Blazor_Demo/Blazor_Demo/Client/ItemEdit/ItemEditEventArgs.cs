using Blazor_Demo.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo.Client.ItemEdit
{
    public class ItemEditEventArgs : EventArgs
    {
        public BaseItem Item { get; set; }
    }
}
