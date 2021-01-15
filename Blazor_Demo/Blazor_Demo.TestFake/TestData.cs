using Blazor_Demo.Shared.Entities;
using Blazor_Demo.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Blazor_Demo.TestFake
{
    public class TestData
    {
        public static User Tuser { get; private set; }

        public static void CreateTestUser()
        {
            var user = new User();
            user.Id = 1;
            user.UserName = "kevin1234";
            user.LastName = "Park";
            user.FirstName = "Kevin";
            user.Password = "test123";
            user.Gender = GenderTypeEnum.Male;
            user.UserItems = new ObservableCollection<BaseItem>();

            var textItem = new TextItem();
            textItem.ParentId = user.Id;
            textItem.Id = 1;
            textItem.Title = "Testing";
            textItem.SubTitle = "Sub Testing";
            textItem.Detail = "Detail testing";
            textItem.ItemTypeEnum = ItemTypeEnum.Text;
            textItem.Position = 1;
            user.UserItems.Add(textItem);

            var user2 = new User();
            user2.Id = 1;
            user2.UserName = "kevin-user2";
            user2.LastName = "Park";
            user2.FirstName = "Kevin";
            user2.Password = "test123";
            user2.Gender = GenderTypeEnum.Male;
            user2.UserItems = new ObservableCollection<BaseItem>();

            var urlItem = new UrlItem();
            urlItem.ParentId = urlItem.Id;
            urlItem.Id = 2;
            urlItem.Title = "Testing 2";
            urlItem.Url = "www.google.com";
            urlItem.ItemTypeEnum = ItemTypeEnum.Url;
            urlItem.Position = 2;
            user2.UserItems.Add(urlItem);


            var urlItem2 = new UrlItem();
            urlItem2.ParentId = urlItem2.Id;
            urlItem2.Id = 2;
            urlItem2.Title = "Testing 3";
            urlItem2.Url = "www.facebook.com";
            urlItem2.ItemTypeEnum = ItemTypeEnum.Url;
            urlItem2.Position = 2;
            user.UserItems.Add(urlItem2);



            var parentItem = new ParentItem();
            parentItem.ParentId = user.Id;
            parentItem.Id = 3;
            parentItem.Title = "Testing 4";
            parentItem.ItemTypeEnum = ItemTypeEnum.Parent;
            parentItem.Position = 3;
            parentItem.ChildItems = new ObservableCollection<ChildItem>();
            user.UserItems.Add(parentItem);

            var childItem = new ChildItem();
            childItem.ParentId = parentItem.Id;
            parentItem.ChildItems.Add(childItem);
            childItem.Id = 4;
            childItem.Position = 1;
            childItem.Title = "Cut";


            var childItem2 = new ChildItem();
            childItem2.ParentId = parentItem.Id;
            parentItem.ChildItems.Add(childItem2);
            childItem2.Id = 5;
            childItem2.Position = 1;
            childItem2.Title = "Cut";

            Tuser = user;

        }
    }
}
