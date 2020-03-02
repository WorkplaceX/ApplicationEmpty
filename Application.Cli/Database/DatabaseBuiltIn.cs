// Do not modify this file. It's generated by Framework.Cli.

namespace DatabaseBuiltIn.dbo
{
    using System;
    using System.Collections.Generic;
    using Database.dbo;

    public static class FrameworkConfigGridBuiltInTableApplicationCli
    {
        public static List<FrameworkConfigGridBuiltIn> RowList
        {
            get
            {
                var result = new List<FrameworkConfigGridBuiltIn>();
                result.Add(new FrameworkConfigGridBuiltIn() { Id = 3, IdName = "Demo.Language; ", TableId = 14, TableIdName = "Demo.Language", TableNameCSharp = "Demo.Language", ConfigName = null, RowCountMax = null, IsAllowInsert = null, IsExist = true });
                result.Add(new FrameworkConfigGridBuiltIn() { Id = 4, IdName = "Demo.Navigation; ", TableId = 29, TableIdName = "Demo.Navigation", TableNameCSharp = "Demo.Navigation", ConfigName = null, RowCountMax = 20, IsAllowInsert = null, IsExist = true });
                result.Add(new FrameworkConfigGridBuiltIn() { Id = 5, IdName = "Demo.RawOpenFlightsAirport; ", TableId = 34, TableIdName = "Demo.RawOpenFlightsAirport", TableNameCSharp = "Demo.RawOpenFlightsAirport", ConfigName = null, RowCountMax = null, IsAllowInsert = null, IsExist = true });
                result.Add(new FrameworkConfigGridBuiltIn() { Id = 6, IdName = "Demo.RawWikipediaAircraft; ", TableId = 36, TableIdName = "Demo.RawWikipediaAircraft", TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = null, RowCountMax = 5, IsAllowInsert = null, IsExist = true });
                result.Add(new FrameworkConfigGridBuiltIn() { Id = 7, IdName = "Demo.RawWikipediaAircraft; G", TableId = 36, TableIdName = "Demo.RawWikipediaAircraft", TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = "G", RowCountMax = 5, IsAllowInsert = null, IsExist = true });
                result.Add(new FrameworkConfigGridBuiltIn() { Id = 8, IdName = "Demo.RoadmapDisplay; ", TableId = 42, TableIdName = "Demo.RoadmapDisplay", TableNameCSharp = "Demo.RoadmapDisplay", ConfigName = null, RowCountMax = null, IsAllowInsert = null, IsExist = true });
                return result;
            }
        }
    }

    public static class FrameworkConfigFieldBuiltInTableApplicationCli
    {
        public static List<FrameworkConfigFieldBuiltIn> RowList
        {
            get
            {
                var result = new List<FrameworkConfigFieldBuiltIn>();
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 19, ConfigGridId = 4, ConfigGridIdName = "Demo.Navigation; ", FieldId = 179, FieldIdName = "Demo.Navigation; Id", InstanceName = null, TableNameCSharp = "Demo.Navigation", ConfigName = null, FieldNameCSharp = "Id", Text = null, Description = null, IsVisible = true, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 20, ConfigGridId = 4, ConfigGridIdName = "Demo.Navigation; ", FieldId = 183, FieldIdName = "Demo.Navigation; PageName", InstanceName = null, TableNameCSharp = "Demo.Navigation", ConfigName = null, FieldNameCSharp = "PageName", Text = "PAGE", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 21, ConfigGridId = 4, ConfigGridIdName = "Demo.Navigation; ", FieldId = 180, FieldIdName = "Demo.Navigation; ParentId", InstanceName = null, TableNameCSharp = "Demo.Navigation", ConfigName = null, FieldNameCSharp = "ParentId", Text = null, Description = null, IsVisible = true, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 22, ConfigGridId = 5, ConfigGridIdName = "Demo.RawOpenFlightsAirport; ", FieldId = 208, FieldIdName = "Demo.RawOpenFlightsAirport; AirportID", InstanceName = null, TableNameCSharp = "Demo.RawOpenFlightsAirport", ConfigName = null, FieldNameCSharp = "AirportID", Text = null, Description = null, IsVisible = false, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 23, ConfigGridId = 5, ConfigGridIdName = "Demo.RawOpenFlightsAirport; ", FieldId = 210, FieldIdName = "Demo.RawOpenFlightsAirport; City", InstanceName = null, TableNameCSharp = "Demo.RawOpenFlightsAirport", ConfigName = null, FieldNameCSharp = "City", Text = "My City", Description = "This is the city of the airport", IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 24, ConfigGridId = 6, ConfigGridIdName = "Demo.RawWikipediaAircraft; ", FieldId = 226, FieldIdName = "Demo.RawWikipediaAircraft; IataCode", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = null, FieldNameCSharp = "IataCode", Text = "IATA Code", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 25, ConfigGridId = 7, ConfigGridIdName = "Demo.RawWikipediaAircraft; G", FieldId = 226, FieldIdName = "Demo.RawWikipediaAircraft; IataCode", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = "G", FieldNameCSharp = "IataCode", Text = "IATA Code", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 26, ConfigGridId = 7, ConfigGridIdName = "Demo.RawWikipediaAircraft; G", FieldId = 225, FieldIdName = "Demo.RawWikipediaAircraft; IcaoCode", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = "G", FieldNameCSharp = "IcaoCode", Text = "ICAO Code", Description = null, IsVisible = null, IsReadOnly = true, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 27, ConfigGridId = 6, ConfigGridIdName = "Demo.RawWikipediaAircraft; ", FieldId = 225, FieldIdName = "Demo.RawWikipediaAircraft; IcaoCode", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = null, FieldNameCSharp = "IcaoCode", Text = "ICAO Code", Description = null, IsVisible = null, IsReadOnly = true, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 28, ConfigGridId = 6, ConfigGridIdName = "Demo.RawWikipediaAircraft; ", FieldId = 227, FieldIdName = "Demo.RawWikipediaAircraft; Model", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = null, FieldNameCSharp = "Model", Text = "Image", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 29, ConfigGridId = 7, ConfigGridIdName = "Demo.RawWikipediaAircraft; G", FieldId = 227, FieldIdName = "Demo.RawWikipediaAircraft; Model", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = "G", FieldNameCSharp = "Model", Text = "Image", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 30, ConfigGridId = 7, ConfigGridIdName = "Demo.RawWikipediaAircraft; G", FieldId = 230, FieldIdName = "Demo.RawWikipediaAircraft; ModelImageUrl", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = "G", FieldNameCSharp = "ModelImageUrl", Text = "Image Link", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 31, ConfigGridId = 6, ConfigGridIdName = "Demo.RawWikipediaAircraft; ", FieldId = 230, FieldIdName = "Demo.RawWikipediaAircraft; ModelImageUrl", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = null, FieldNameCSharp = "ModelImageUrl", Text = "Image Link", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 32, ConfigGridId = 6, ConfigGridIdName = "Demo.RawWikipediaAircraft; ", FieldId = 229, FieldIdName = "Demo.RawWikipediaAircraft; ModelTitle", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = null, FieldNameCSharp = "ModelTitle", Text = "Title", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 33, ConfigGridId = 7, ConfigGridIdName = "Demo.RawWikipediaAircraft; G", FieldId = 229, FieldIdName = "Demo.RawWikipediaAircraft; ModelTitle", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = "G", FieldNameCSharp = "ModelTitle", Text = "Title", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 34, ConfigGridId = 7, ConfigGridIdName = "Demo.RawWikipediaAircraft; G", FieldId = 228, FieldIdName = "Demo.RawWikipediaAircraft; ModelUrl", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = "G", FieldNameCSharp = "ModelUrl", Text = "Url", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 35, ConfigGridId = 6, ConfigGridIdName = "Demo.RawWikipediaAircraft; ", FieldId = 228, FieldIdName = "Demo.RawWikipediaAircraft; ModelUrl", InstanceName = null, TableNameCSharp = "Demo.RawWikipediaAircraft", ConfigName = null, FieldNameCSharp = "ModelUrl", Text = "Url", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 36, ConfigGridId = 8, ConfigGridIdName = "Demo.RoadmapDisplay; ", FieldId = 288, FieldIdName = "Demo.RoadmapDisplay; LoginUserText", InstanceName = null, TableNameCSharp = "Demo.RoadmapDisplay", ConfigName = null, FieldNameCSharp = "LoginUserText", Text = "User", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 37, ConfigGridId = 8, ConfigGridIdName = "Demo.RoadmapDisplay; ", FieldId = 279, FieldIdName = "Demo.RoadmapDisplay; Name", InstanceName = null, TableNameCSharp = "Demo.RoadmapDisplay", ConfigName = null, FieldNameCSharp = "Name", Text = null, Description = null, IsVisible = false, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 38, ConfigGridId = 8, ConfigGridIdName = "Demo.RoadmapDisplay; ", FieldId = 282, FieldIdName = "Demo.RoadmapDisplay; RoadmapCategoryText", InstanceName = null, TableNameCSharp = "Demo.RoadmapDisplay", ConfigName = null, FieldNameCSharp = "RoadmapCategoryText", Text = "Category", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 39, ConfigGridId = 8, ConfigGridIdName = "Demo.RoadmapDisplay; ", FieldId = 284, FieldIdName = "Demo.RoadmapDisplay; RoadmapModuleText", InstanceName = null, TableNameCSharp = "Demo.RoadmapDisplay", ConfigName = null, FieldNameCSharp = "RoadmapModuleText", Text = "Module", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 40, ConfigGridId = 8, ConfigGridIdName = "Demo.RoadmapDisplay; ", FieldId = 286, FieldIdName = "Demo.RoadmapDisplay; RoadmapPriorityText", InstanceName = null, TableNameCSharp = "Demo.RoadmapDisplay", ConfigName = null, FieldNameCSharp = "RoadmapPriorityText", Text = "Priority", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                result.Add(new FrameworkConfigFieldBuiltIn() { Id = 41, ConfigGridId = 8, ConfigGridIdName = "Demo.RoadmapDisplay; ", FieldId = 290, FieldIdName = "Demo.RoadmapDisplay; RoadmapStateText", InstanceName = null, TableNameCSharp = "Demo.RoadmapDisplay", ConfigName = null, FieldNameCSharp = "RoadmapStateText", Text = "State", Description = null, IsVisible = null, IsReadOnly = null, Sort = null, IsExist = true });
                return result;
            }
        }
    }
}

namespace DatabaseBuiltIn.Demo
{
    using System;
    using System.Collections.Generic;
    using Database.Demo;

    public static class NavigationBuiltInTableApplicationCli
    {
        public static List<NavigationBuiltIn> RowList
        {
            get
            {
                var result = new List<NavigationBuiltIn>();
                result.Add(new NavigationBuiltIn() { Id = 1, IdName = "Home", ParentId = null, ParentIdName = null, Name = "Home", TextHtml = "<i class=\"fas fa-home\"></i> Home", PageName = null, Sort = 1 });
                result.Add(new NavigationBuiltIn() { Id = 2, IdName = "About", ParentId = null, ParentIdName = null, Name = "About", TextHtml = "<i class=\"fas fa-bullhorn\"></i> About", PageName = "About", Sort = 9.6 });
                result.Add(new NavigationBuiltIn() { Id = 3, IdName = "LoginUser", ParentId = null, ParentIdName = null, Name = "LoginUser", TextHtml = "<i class=\"fas fa-user\"></i> User", PageName = null, Sort = 10 });
                result.Add(new NavigationBuiltIn() { Id = 4, IdName = "Roadmap", ParentId = null, ParentIdName = null, Name = "Roadmap", TextHtml = "<i class=\"fas fa-road\"></i> Roadmap", PageName = "Roadmap", Sort = 9 });
                result.Add(new NavigationBuiltIn() { Id = 5, IdName = "LoginRoleManagement", ParentId = 3, ParentIdName = "LoginUser", Name = "LoginRoleManagement", TextHtml = "<i class=\'fas fa-hat-cowboy\'></i> Role Management", PageName = "LoginRole", Sort = 2.5 });
                result.Add(new NavigationBuiltIn() { Id = 6, IdName = "Airport", ParentId = 1, ParentIdName = "Home", Name = "Airport", TextHtml = "<i class=\"fas fa-plane-departure\"></i> Airport", PageName = "Airport", Sort = 0.1 });
                result.Add(new NavigationBuiltIn() { Id = 7, IdName = "LoginSignIn", ParentId = 3, ParentIdName = "LoginUser", Name = "LoginSignIn", TextHtml = "<i class=\"fas fa-sign-in-alt\"></i> Sign In", PageName = null, Sort = 1 });
                result.Add(new NavigationBuiltIn() { Id = 8, IdName = "LoginSignOut", ParentId = 3, ParentIdName = "LoginUser", Name = "LoginSignOut", TextHtml = "<i class=\"fas fa-sign-out-alt\"></i> Sign Out", PageName = null, Sort = 3 });
                result.Add(new NavigationBuiltIn() { Id = 9, IdName = "LoginProfile", ParentId = 3, ParentIdName = "LoginUser", Name = "LoginProfile", TextHtml = "<i class=\"far fa-id-card\"></i> Profile", PageName = null, Sort = 2 });
                result.Add(new NavigationBuiltIn() { Id = 10, IdName = "LoginUserManagement", ParentId = 3, ParentIdName = "LoginUser", Name = "LoginUserManagement", TextHtml = "<i class=\"fas fa-user\"></i> User Management", PageName = "LoginUser", Sort = 2.4 });
                result.Add(new NavigationBuiltIn() { Id = 11, IdName = "Airplane", ParentId = 1, ParentIdName = "Home", Name = "Airplane", TextHtml = "<i class=\"fas fa-plane\"></i> Airplane", PageName = "Home", Sort = 0.2 });
                return result;
            }
        }
    }

    public static class LoginPermissionBuiltInTableApplicationCli
    {
        public static List<LoginPermissionBuiltIn> RowList
        {
            get
            {
                var result = new List<LoginPermissionBuiltIn>();
                result.Add(new LoginPermissionBuiltIn() { Id = 4, IdName = "Calendar Modify", Name = "Calendar Modify", Description = "Allows user to modify the calendar.", IsBuiltIn = false, IsExist = true });
                result.Add(new LoginPermissionBuiltIn() { Id = 5, IdName = "Roadmap Modify", Name = "Roadmap Modify", Description = "Allows user to modify the development roadmap.", IsBuiltIn = false, IsExist = true });
                result.Add(new LoginPermissionBuiltIn() { Id = 6, IdName = "Language Modify", Name = "Language Modify", Description = "Allows user to add new languages.", IsBuiltIn = false, IsExist = true });
                result.Add(new LoginPermissionBuiltIn() { Id = 7, IdName = "AirportPage Show", Name = "AirportPage Show", Description = "Allows user to see airport page.", IsBuiltIn = false, IsExist = true });
                return result;
            }
        }
    }

    public static class LoginRoleBuiltInTableApplicationCli
    {
        public static List<LoginRoleBuiltIn> RowList
        {
            get
            {
                var result = new List<LoginRoleBuiltIn>();
                result.Add(new LoginRoleBuiltIn() { Id = 1, IdName = "Administrator", Name = "Administrator", Description = "Administrator role" });
                result.Add(new LoginRoleBuiltIn() { Id = 2, IdName = "Guest", Name = "Guest", Description = "Guest user (not logged in)" });
                result.Add(new LoginRoleBuiltIn() { Id = 3, IdName = "BackOffice", Name = "BackOffice", Description = "Power user" });
                result.Add(new LoginRoleBuiltIn() { Id = 4, IdName = "Developer", Name = "Developer", Description = "Developer role" });
                return result;
            }
        }
    }

    public static class LoginRolePermissionBuiltInTableApplicationCli
    {
        public static List<LoginRolePermissionBuiltIn> RowList
        {
            get
            {
                var result = new List<LoginRolePermissionBuiltIn>();
                result.Add(new LoginRolePermissionBuiltIn() { Id = 1, RoleId = 1, RoleIdName = "Administrator", PermissionId = 4, PermissionIdName = "Calendar Modify", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 2, RoleId = 1, RoleIdName = "Administrator", PermissionId = 5, PermissionIdName = "Roadmap Modify", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 3, RoleId = 3, RoleIdName = "BackOffice", PermissionId = 4, PermissionIdName = "Calendar Modify", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 4, RoleId = 3, RoleIdName = "BackOffice", PermissionId = 5, PermissionIdName = "Roadmap Modify", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 5, RoleId = 2, RoleIdName = "Guest", PermissionId = 4, PermissionIdName = "Calendar Modify", IsActive = false });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 6, RoleId = 2, RoleIdName = "Guest", PermissionId = 5, PermissionIdName = "Roadmap Modify", IsActive = false });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 7, RoleId = 1, RoleIdName = "Administrator", PermissionId = 6, PermissionIdName = "Language Modify", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 8, RoleId = 2, RoleIdName = "Guest", PermissionId = 7, PermissionIdName = "AirportPage Show", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 9, RoleId = 1, RoleIdName = "Administrator", PermissionId = 7, PermissionIdName = "AirportPage Show", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 10, RoleId = 4, RoleIdName = "Developer", PermissionId = 3, PermissionIdName = "Developer", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 11, RoleId = 4, RoleIdName = "Developer", PermissionId = 2, PermissionIdName = "Administrator", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 12, RoleId = 4, RoleIdName = "Developer", PermissionId = 1, PermissionIdName = "Guest", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 13, RoleId = 2, RoleIdName = "Guest", PermissionId = 1, PermissionIdName = "Guest", IsActive = true });
                result.Add(new LoginRolePermissionBuiltIn() { Id = 14, RoleId = 1, RoleIdName = "Administrator", PermissionId = 2, PermissionIdName = "Administrator", IsActive = true });
                return result;
            }
        }
    }

    public static class LoginUserBuiltInTableApplicationCli
    {
        public static List<LoginUserBuiltIn> RowList
        {
            get
            {
                var result = new List<LoginUserBuiltIn>();
                result.Add(new LoginUserBuiltIn() { Id = 1, IdName = "John", Name = "John", Password = "J33", IsBuiltIn = false, IsExist = true });
                result.Add(new LoginUserBuiltIn() { Id = 2, IdName = "Marc", Name = "Marc", Password = "DAdkm", IsBuiltIn = false, IsExist = true });
                result.Add(new LoginUserBuiltIn() { Id = 3, IdName = "Guest", Name = "Guest", Password = "Guest33", IsBuiltIn = true, IsExist = true });
                result.Add(new LoginUserBuiltIn() { Id = 4, IdName = "Administrator", Name = "Administrator", Password = null, IsBuiltIn = true, IsExist = true });
                result.Add(new LoginUserBuiltIn() { Id = 5, IdName = "Developer", Name = "Developer", Password = "dev55", IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }

    public static class LoginUserRoleBuiltInTableApplicationCli
    {
        public static List<LoginUserRoleBuiltIn> RowList
        {
            get
            {
                var result = new List<LoginUserRoleBuiltIn>();
                result.Add(new LoginUserRoleBuiltIn() { Id = 1, UserId = 3, UserIdName = "Guest", RoleId = 1, RoleIdName = "Administrator", IsActive = false });
                result.Add(new LoginUserRoleBuiltIn() { Id = 2, UserId = 3, UserIdName = "Guest", RoleId = 2, RoleIdName = "Guest", IsActive = true });
                result.Add(new LoginUserRoleBuiltIn() { Id = 3, UserId = 3, UserIdName = "Guest", RoleId = 3, RoleIdName = "BackOffice", IsActive = false });
                result.Add(new LoginUserRoleBuiltIn() { Id = 4, UserId = 4, UserIdName = "Administrator", RoleId = 1, RoleIdName = "Administrator", IsActive = true });
                result.Add(new LoginUserRoleBuiltIn() { Id = 5, UserId = 4, UserIdName = "Administrator", RoleId = 2, RoleIdName = "Guest", IsActive = true });
                result.Add(new LoginUserRoleBuiltIn() { Id = 6, UserId = 4, UserIdName = "Administrator", RoleId = 3, RoleIdName = "BackOffice", IsActive = true });
                result.Add(new LoginUserRoleBuiltIn() { Id = 7, UserId = 2, UserIdName = "Marc", RoleId = 2, RoleIdName = "Guest", IsActive = true });
                result.Add(new LoginUserRoleBuiltIn() { Id = 8, UserId = 1, UserIdName = "John", RoleId = 2, RoleIdName = "Guest", IsActive = null });
                result.Add(new LoginUserRoleBuiltIn() { Id = 9, UserId = 1, UserIdName = "John", RoleId = 3, RoleIdName = "BackOffice", IsActive = true });
                result.Add(new LoginUserRoleBuiltIn() { Id = 10, UserId = 5, UserIdName = "Developer", RoleId = 4, RoleIdName = "Developer", IsActive = true });
                return result;
            }
        }
    }

    public static class RoadmapCategoryBuiltInTableApplicationCli
    {
        public static List<RoadmapCategoryBuiltIn> RowList
        {
            get
            {
                var result = new List<RoadmapCategoryBuiltIn>();
                result.Add(new RoadmapCategoryBuiltIn() { Id = 1, IdName = "Feature", Name = "Feature", Text = "Feature", Description = "Software Feature", IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapCategoryBuiltIn() { Id = 2, IdName = "Bug", Name = "Bug", Text = "Bug", Description = "Software Bug", IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }

    public static class RoadmapModuleBuiltInTableApplicationCli
    {
        public static List<RoadmapModuleBuiltIn> RowList
        {
            get
            {
                var result = new List<RoadmapModuleBuiltIn>();
                result.Add(new RoadmapModuleBuiltIn() { Id = 1, IdName = "Framework", Name = "Framework", Text = "Framework", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapModuleBuiltIn() { Id = 2, IdName = "Application", Name = "Application", Text = "Application", Description = null, IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }

    public static class RoadmapPriorityBuiltInTableApplicationCli
    {
        public static List<RoadmapPriorityBuiltIn> RowList
        {
            get
            {
                var result = new List<RoadmapPriorityBuiltIn>();
                result.Add(new RoadmapPriorityBuiltIn() { Id = 1, IdName = "Low", Name = "Low", Text = "Low (Green)", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapPriorityBuiltIn() { Id = 2, IdName = "Medium", Name = "Medium", Text = "Medium (Blue)", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapPriorityBuiltIn() { Id = 3, IdName = "High", Name = "High", Text = "High (Orange)", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapPriorityBuiltIn() { Id = 4, IdName = "Critical", Name = "Critical", Text = "Critical (Red)", Description = null, IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }

    public static class RoadmapStateBuiltInTableApplicationCli
    {
        public static List<RoadmapStateBuiltIn> RowList
        {
            get
            {
                var result = new List<RoadmapStateBuiltIn>();
                result.Add(new RoadmapStateBuiltIn() { Id = 1, IdName = "New", Name = "New", Text = "New", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapStateBuiltIn() { Id = 2, IdName = "Open", Name = "Open", Text = "Open", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapStateBuiltIn() { Id = 3, IdName = "In Progress", Name = "In Progress", Text = "In Progress", Description = null, IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapStateBuiltIn() { Id = 4, IdName = "Closed", Name = "Closed", Text = "Closed", Description = null, IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }

    public static class RoadmapBuiltInTableApplicationCli
    {
        public static List<RoadmapBuiltIn> RowList
        {
            get
            {
                var result = new List<RoadmapBuiltIn>();
                result.Add(new RoadmapBuiltIn() { Id = 1, Name = Guid.Parse("c6e421fa-8f78-424d-9e0f-64da942e740f"), Description = "Method Data.Update(); if two users modified same record.", RoadmapCategoryId = 2, RoadmapCategoryIdName = "Bug", RoadmapModuleId = 1, RoadmapModuleIdName = "Framework", RoadmapPriorityId = 1, RoadmapPriorityIdName = "Low", LoginUserId = 5, LoginUserIdName = "Developer", RoadmapStateId = 1, RoadmapStateIdName = "New", IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapBuiltIn() { Id = 2, Name = Guid.Parse("0acc2649-e499-4c3d-a329-7e6282747973"), Description = "Cell multiline", RoadmapCategoryId = 1, RoadmapCategoryIdName = "Feature", RoadmapModuleId = 1, RoadmapModuleIdName = "Framework", RoadmapPriorityId = 1, RoadmapPriorityIdName = "Low", LoginUserId = 5, LoginUserIdName = "Developer", RoadmapStateId = 1, RoadmapStateIdName = "New", IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapBuiltIn() { Id = 3, Name = Guid.Parse("da61059f-e91b-4379-bb13-f69731a2ea4c"), Description = "Upload image", RoadmapCategoryId = 1, RoadmapCategoryIdName = "Feature", RoadmapModuleId = 1, RoadmapModuleIdName = "Framework", RoadmapPriorityId = 1, RoadmapPriorityIdName = "Low", LoginUserId = 5, LoginUserIdName = "Developer", RoadmapStateId = 1, RoadmapStateIdName = "New", IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapBuiltIn() { Id = 5, Name = Guid.Parse("ba7a91fe-8a09-45ab-a3f5-a4f94bceb86d"), Description = "Roadmap priority color", RoadmapCategoryId = 1, RoadmapCategoryIdName = "Feature", RoadmapModuleId = 2, RoadmapModuleIdName = "Application", RoadmapPriorityId = 3, RoadmapPriorityIdName = "High", LoginUserId = 5, LoginUserIdName = "Developer", RoadmapStateId = 3, RoadmapStateIdName = "In Progress", IsBuiltIn = true, IsExist = true });
                result.Add(new RoadmapBuiltIn() { Id = 6, Name = Guid.Parse("4ef7e1d7-eeb3-4cf0-bbb5-cd52428c9caa"), Description = "Dropdown do not select first row", RoadmapCategoryId = 2, RoadmapCategoryIdName = "Bug", RoadmapModuleId = 1, RoadmapModuleIdName = "Framework", RoadmapPriorityId = 3, RoadmapPriorityIdName = "High", LoginUserId = 5, LoginUserIdName = "Developer", RoadmapStateId = 2, RoadmapStateIdName = "Open", IsBuiltIn = true, IsExist = true });
                return result;
            }
        }
    }
}
