// Do not modify this file. It's generated by Framework.Cli.

namespace DatabaseBuiltIn.dbo
{
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
                return result;
            }
        }
    }
}

namespace DatabaseBuiltIn.Demo
{
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
}
