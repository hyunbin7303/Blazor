﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor_Demo.Shared.Entities
{
    public class TextItem : BaseItem
    {
        public string SubTitle 
        { 
            get => _subTitle;
            set => SetProperty(ref _subTitle, value);
        }
        private string _subTitle;
        
        public string Detail 
        { 
            get => _detail; 
            set => SetProperty(ref _detail, value);
         }
        private string _detail;
    }
}
