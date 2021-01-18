using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blazor_Demo.Shared.Entities
{
    public class ParentItem : BaseItem
    {
        private ObservableCollection<ChildItem> _childItems;

        public ObservableCollection<ChildItem> ChildItems
        {
            get => _childItems;
            set
            {
                if (value == _childItems)
                {
                    return;
                }
                _childItems = value;
                NotifyPropertyChanged();
            }
        }
    }
}
