// Do not modify this file. It's generated by Framework.Cli.

namespace Database.Demo
{
    using Framework.DataAccessLayer;
    using System;

    [SqlTable("Demo", "CountryDisplay")]
    public class CountryDisplay : Row
    {
        [SqlField("Country", FrameworkTypeEnum.Nvarcahr)]
        public string Country { get; set; }

        [SqlField("Code", FrameworkTypeEnum.Nvarcahr)]
        public string Code { get; set; }

        [SqlField("IsWikipedia", FrameworkTypeEnum.Bit)]
        public bool? IsWikipedia { get; set; }

        [SqlField("IsOpenFlightsAirport", FrameworkTypeEnum.Bit)]
        public bool? IsOpenFlightsAirport { get; set; }

        [SqlField("IsOpenFlightsAirline", FrameworkTypeEnum.Bit)]
        public bool? IsOpenFlightsAirline { get; set; }

        [SqlField("IsFlagIconCss", FrameworkTypeEnum.Bit)]
        public bool? IsFlagIconCss { get; set; }

        [SqlField("WikipediaCountryUrl", FrameworkTypeEnum.Nvarcahr)]
        public string WikipediaCountryUrl { get; set; }

        [SqlField("ASFlagIcon", FrameworkTypeEnum.Nvarcahr)]
        public string ASFlagIcon { get; set; }
    }

    [SqlTable("Demo", "CountryDisplayCache")]
    public class CountryDisplayCache : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Country", FrameworkTypeEnum.Nvarcahr)]
        public string Country { get; set; }

        [SqlField("Code", FrameworkTypeEnum.Nvarcahr)]
        public string Code { get; set; }

        [SqlField("IsWikipedia", FrameworkTypeEnum.Bit)]
        public bool? IsWikipedia { get; set; }

        [SqlField("IsOpenFlightsAirport", FrameworkTypeEnum.Bit)]
        public bool? IsOpenFlightsAirport { get; set; }

        [SqlField("IsOpenFlightsAirline", FrameworkTypeEnum.Bit)]
        public bool? IsOpenFlightsAirline { get; set; }

        [SqlField("IsFlagIconCss", FrameworkTypeEnum.Bit)]
        public bool? IsFlagIconCss { get; set; }

        [SqlField("WikipediaCountryUrl", FrameworkTypeEnum.Nvarcahr)]
        public string WikipediaCountryUrl { get; set; }

        [SqlField("ASFlagIcon", FrameworkTypeEnum.Nvarcahr)]
        public string ASFlagIcon { get; set; }
    }

    [SqlTable("Demo", "Language")]
    public class Language : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("TextHtml", FrameworkTypeEnum.Nvarcahr)]
        public string TextHtml { get; set; }
    }

    [SqlTable("Demo", "LanguageBuiltIn")]
    public class LanguageBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("IdName", FrameworkTypeEnum.Nvarcahr)]
        public string IdName { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("TextHtml", FrameworkTypeEnum.Nvarcahr)]
        public string TextHtml { get; set; }
    }

    [SqlTable("Demo", "LoginPermission")]
    public class LoginPermission : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "LoginPermissionBuiltIn")]
    public class LoginPermissionBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("IdName", FrameworkTypeEnum.Nvarcahr)]
        public string IdName { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "LoginRole")]
    public class LoginRole : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }
    }

    [SqlTable("Demo", "LoginRoleBuiltIn")]
    public class LoginRoleBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("IdName", FrameworkTypeEnum.Nvarcahr)]
        public string IdName { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }
    }

    [SqlTable("Demo", "LoginRolePermission")]
    public class LoginRolePermission : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("RoleId", FrameworkTypeEnum.Int)]
        public int RoleId { get; set; }

        [SqlField("PermissionId", FrameworkTypeEnum.Int)]
        public int PermissionId { get; set; }

        [SqlField("IsActive", FrameworkTypeEnum.Bit)]
        public bool? IsActive { get; set; }
    }

    [SqlTable("Demo", "LoginRolePermissionBuiltIn")]
    public class LoginRolePermissionBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("RoleId", FrameworkTypeEnum.Int)]
        public int RoleId { get; set; }

        [SqlField("RoleIdName", FrameworkTypeEnum.Nvarcahr)]
        public string RoleIdName { get; set; }

        [SqlField("PermissionId", FrameworkTypeEnum.Int)]
        public int PermissionId { get; set; }

        [SqlField("PermissionIdName", FrameworkTypeEnum.Nvarcahr)]
        public string PermissionIdName { get; set; }

        [SqlField("IsActive", FrameworkTypeEnum.Bit)]
        public bool? IsActive { get; set; }
    }

    [SqlTable("Demo", "LoginRolePermissionDisplay")]
    public class LoginRolePermissionDisplay : Row
    {
        [SqlField("RoleId", FrameworkTypeEnum.Int)]
        public int RoleId { get; set; }

        [SqlField("RoleName", FrameworkTypeEnum.Nvarcahr)]
        public string RoleName { get; set; }

        [SqlField("RoleDescription", FrameworkTypeEnum.Nvarcahr)]
        public string RoleDescription { get; set; }

        [SqlField("PermissionId", FrameworkTypeEnum.Int)]
        public int PermissionId { get; set; }

        [SqlField("PermissionName", FrameworkTypeEnum.Nvarcahr)]
        public string PermissionName { get; set; }

        [SqlField("PermissionDescription", FrameworkTypeEnum.Nvarcahr)]
        public string PermissionDescription { get; set; }

        [SqlField("IsActive", FrameworkTypeEnum.Bit)]
        public bool? IsActive { get; set; }
    }

    [SqlTable("Demo", "LoginUser")]
    public class LoginUser : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Password", FrameworkTypeEnum.Nvarcahr)]
        public string Password { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "LoginUserBuiltIn")]
    public class LoginUserBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("IdName", FrameworkTypeEnum.Nvarcahr)]
        public string IdName { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Password", FrameworkTypeEnum.Nvarcahr)]
        public string Password { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "LoginUserPermissionDisplay")]
    public class LoginUserPermissionDisplay : Row
    {
        [SqlField("UserId", FrameworkTypeEnum.Int)]
        public int UserId { get; set; }

        [SqlField("UserName", FrameworkTypeEnum.Nvarcahr)]
        public string UserName { get; set; }

        [SqlField("PermissionId", FrameworkTypeEnum.Int)]
        public int PermissionId { get; set; }

        [SqlField("PermissionName", FrameworkTypeEnum.Nvarcahr)]
        public string PermissionName { get; set; }
    }

    [SqlTable("Demo", "LoginUserRole")]
    public class LoginUserRole : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("UserId", FrameworkTypeEnum.Int)]
        public int UserId { get; set; }

        [SqlField("RoleId", FrameworkTypeEnum.Int)]
        public int RoleId { get; set; }

        [SqlField("IsActive", FrameworkTypeEnum.Bit)]
        public bool? IsActive { get; set; }
    }

    [SqlTable("Demo", "LoginUserRoleBuiltIn")]
    public class LoginUserRoleBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("UserId", FrameworkTypeEnum.Int)]
        public int UserId { get; set; }

        [SqlField("UserIdName", FrameworkTypeEnum.Nvarcahr)]
        public string UserIdName { get; set; }

        [SqlField("RoleId", FrameworkTypeEnum.Int)]
        public int RoleId { get; set; }

        [SqlField("RoleIdName", FrameworkTypeEnum.Nvarcahr)]
        public string RoleIdName { get; set; }

        [SqlField("IsActive", FrameworkTypeEnum.Bit)]
        public bool? IsActive { get; set; }
    }

    [SqlTable("Demo", "LoginUserRoleDisplay")]
    public class LoginUserRoleDisplay : Row
    {
        [SqlField("UserId", FrameworkTypeEnum.Int)]
        public int UserId { get; set; }

        [SqlField("UserName", FrameworkTypeEnum.Nvarcahr)]
        public string UserName { get; set; }

        [SqlField("RoleId", FrameworkTypeEnum.Int)]
        public int RoleId { get; set; }

        [SqlField("RoleName", FrameworkTypeEnum.Nvarcahr)]
        public string RoleName { get; set; }

        [SqlField("IsActive", FrameworkTypeEnum.Bit)]
        public bool? IsActive { get; set; }
    }

    [SqlTable("Demo", "Navigation")]
    public class Navigation : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("ParentId", FrameworkTypeEnum.Int)]
        public int? ParentId { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("TextHtml", FrameworkTypeEnum.Nvarcahr)]
        public string TextHtml { get; set; }

        [SqlField("PageName", FrameworkTypeEnum.Nvarcahr)]
        public string PageName { get; set; }

        [SqlField("Sort", FrameworkTypeEnum.Float)]
        public double? Sort { get; set; }
    }

    [SqlTable("Demo", "NavigationBuiltIn")]
    public class NavigationBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("IdName", FrameworkTypeEnum.Nvarcahr)]
        public string IdName { get; set; }

        [SqlField("ParentId", FrameworkTypeEnum.Int)]
        public int? ParentId { get; set; }

        [SqlField("ParentIdName", FrameworkTypeEnum.Nvarcahr)]
        public string ParentIdName { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("TextHtml", FrameworkTypeEnum.Nvarcahr)]
        public string TextHtml { get; set; }

        [SqlField("PageName", FrameworkTypeEnum.Nvarcahr)]
        public string PageName { get; set; }

        [SqlField("Sort", FrameworkTypeEnum.Float)]
        public double? Sort { get; set; }
    }

    [SqlTable("Demo", "NavigationDisplay")]
    public class NavigationDisplay : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int? Id { get; set; }

        [SqlField("NavigationId", FrameworkTypeEnum.Int)]
        public int? NavigationId { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Level", FrameworkTypeEnum.Int)]
        public int? Level { get; set; }

        [SqlField("Path", FrameworkTypeEnum.Nvarcahr)]
        public string Path { get; set; }
    }

    [SqlTable("Demo", "Raw.FlagIconCss.Country")]
    public class RawFlagIconCssCountry : Row
    {
        [SqlField("Code", FrameworkTypeEnum.Nvarcahr)]
        public string Code { get; set; }

        [SqlField("FlagIcon", FrameworkTypeEnum.Nvarcahr)]
        public string FlagIcon { get; set; }
    }

    [SqlTable("Demo", "Raw.OpenFlights.Airline")]
    public class RawOpenFlightsAirline : Row
    {
        [SqlField("Airline ID", FrameworkTypeEnum.Nvarcahr)]
        public string AirlineID { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Alias", FrameworkTypeEnum.Nvarcahr)]
        public string Alias { get; set; }

        [SqlField("IATA", FrameworkTypeEnum.Nvarcahr)]
        public string IATA { get; set; }

        [SqlField("ICAO", FrameworkTypeEnum.Nvarcahr)]
        public string ICAO { get; set; }

        [SqlField("Callsign", FrameworkTypeEnum.Nvarcahr)]
        public string Callsign { get; set; }

        [SqlField("Country", FrameworkTypeEnum.Nvarcahr)]
        public string Country { get; set; }

        [SqlField("Active", FrameworkTypeEnum.Nvarcahr)]
        public string Active { get; set; }
    }

    [SqlTable("Demo", "Raw.OpenFlights.Airport")]
    public class RawOpenFlightsAirport : Row
    {
        [SqlField("Airport ID", FrameworkTypeEnum.Nvarcahr)]
        public string AirportID { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("City", FrameworkTypeEnum.Nvarcahr)]
        public string City { get; set; }

        [SqlField("Country", FrameworkTypeEnum.Nvarcahr)]
        public string Country { get; set; }

        [SqlField("IATA", FrameworkTypeEnum.Nvarcahr)]
        public string IATA { get; set; }

        [SqlField("ICAO", FrameworkTypeEnum.Nvarcahr)]
        public string ICAO { get; set; }

        [SqlField("Latitude", FrameworkTypeEnum.Nvarcahr)]
        public string Latitude { get; set; }

        [SqlField("Longitude", FrameworkTypeEnum.Nvarcahr)]
        public string Longitude { get; set; }

        [SqlField("Altitude", FrameworkTypeEnum.Nvarcahr)]
        public string Altitude { get; set; }

        [SqlField("Timezone", FrameworkTypeEnum.Nvarcahr)]
        public string Timezone { get; set; }

        [SqlField("DST", FrameworkTypeEnum.Nvarcahr)]
        public string DST { get; set; }

        [SqlField("Tz database time zone", FrameworkTypeEnum.Nvarcahr)]
        public string Tzdatabasetimezone { get; set; }

        [SqlField("Type", FrameworkTypeEnum.Nvarcahr)]
        public string Type { get; set; }

        [SqlField("Source", FrameworkTypeEnum.Nvarcahr)]
        public string Source { get; set; }
    }

    [SqlTable("Demo", "Raw.OpenFlights.Plane")]
    public class RawOpenFlightsPlane : Row
    {
        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("IATA Code", FrameworkTypeEnum.Nvarcahr)]
        public string IATACode { get; set; }

        [SqlField("ICAO Code", FrameworkTypeEnum.Nvarcahr)]
        public string ICAOCode { get; set; }
    }

    [SqlTable("Demo", "Raw.Wikipedia.Aircraft")]
    public class RawWikipediaAircraft : Row
    {
        [SqlField("IcaoCode", FrameworkTypeEnum.Nvarcahr)]
        public string IcaoCode { get; set; }

        [SqlField("IataCode", FrameworkTypeEnum.Nvarcahr)]
        public string IataCode { get; set; }

        [SqlField("Model", FrameworkTypeEnum.Nvarcahr)]
        public string Model { get; set; }

        [SqlField("ModelUrl", FrameworkTypeEnum.Nvarcahr)]
        public string ModelUrl { get; set; }

        [SqlField("ModelTitle", FrameworkTypeEnum.Nvarcahr)]
        public string ModelTitle { get; set; }

        [SqlField("ModelImageUrl", FrameworkTypeEnum.Nvarcahr)]
        public string ModelImageUrl { get; set; }
    }

    [SqlTable("Demo", "Raw.Wikipedia.Country")]
    public class RawWikipediaCountry : Row
    {
        [SqlField("Code", FrameworkTypeEnum.Nvarcahr)]
        public string Code { get; set; }

        [SqlField("Country", FrameworkTypeEnum.Nvarcahr)]
        public string Country { get; set; }

        [SqlField("CountryUrl", FrameworkTypeEnum.Nvarcahr)]
        public string CountryUrl { get; set; }

        [SqlField("Year", FrameworkTypeEnum.Nvarcahr)]
        public string Year { get; set; }

        [SqlField("CcTLD", FrameworkTypeEnum.Nvarcahr)]
        public string CcTLD { get; set; }

        [SqlField("CcTLDUrl", FrameworkTypeEnum.Nvarcahr)]
        public string CcTLDUrl { get; set; }

        [SqlField("Iso", FrameworkTypeEnum.Nvarcahr)]
        public string Iso { get; set; }

        [SqlField("IsoUrl", FrameworkTypeEnum.Nvarcahr)]
        public string IsoUrl { get; set; }

        [SqlField("Notes", FrameworkTypeEnum.Nvarcahr)]
        public string Notes { get; set; }
    }

    [SqlTable("Demo", "Roadmap")]
    public class Roadmap : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Uniqueidentifier)]
        public Guid Name { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("Date", FrameworkTypeEnum.Date)]
        public DateTime? Date { get; set; }

        [SqlField("RoadmapCategoryId", FrameworkTypeEnum.Int)]
        public int? RoadmapCategoryId { get; set; }

        [SqlField("RoadmapModuleId", FrameworkTypeEnum.Int)]
        public int? RoadmapModuleId { get; set; }

        [SqlField("RoadmapPriorityId", FrameworkTypeEnum.Int)]
        public int? RoadmapPriorityId { get; set; }

        [SqlField("LoginUserId", FrameworkTypeEnum.Int)]
        public int? LoginUserId { get; set; }

        [SqlField("RoadmapStateId", FrameworkTypeEnum.Int)]
        public int? RoadmapStateId { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "RoadmapBuiltIn")]
    public class RoadmapBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Uniqueidentifier)]
        public Guid Name { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("Date", FrameworkTypeEnum.Date)]
        public DateTime? Date { get; set; }

        [SqlField("RoadmapCategoryId", FrameworkTypeEnum.Int)]
        public int? RoadmapCategoryId { get; set; }

        [SqlField("RoadmapCategoryIdName", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapCategoryIdName { get; set; }

        [SqlField("RoadmapModuleId", FrameworkTypeEnum.Int)]
        public int? RoadmapModuleId { get; set; }

        [SqlField("RoadmapModuleIdName", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapModuleIdName { get; set; }

        [SqlField("RoadmapPriorityId", FrameworkTypeEnum.Int)]
        public int? RoadmapPriorityId { get; set; }

        [SqlField("RoadmapPriorityIdName", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapPriorityIdName { get; set; }

        [SqlField("LoginUserId", FrameworkTypeEnum.Int)]
        public int? LoginUserId { get; set; }

        [SqlField("LoginUserIdName", FrameworkTypeEnum.Nvarcahr)]
        public string LoginUserIdName { get; set; }

        [SqlField("RoadmapStateId", FrameworkTypeEnum.Int)]
        public int? RoadmapStateId { get; set; }

        [SqlField("RoadmapStateIdName", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapStateIdName { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "RoadmapCategory")]
    public class RoadmapCategory : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Text", FrameworkTypeEnum.Nvarcahr)]
        public string Text { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "RoadmapCategoryBuiltIn")]
    public class RoadmapCategoryBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("IdName", FrameworkTypeEnum.Nvarcahr)]
        public string IdName { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Text", FrameworkTypeEnum.Nvarcahr)]
        public string Text { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "RoadmapDisplay")]
    public class RoadmapDisplay : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Uniqueidentifier)]
        public Guid Name { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("RoadmapCategoryId", FrameworkTypeEnum.Int)]
        public int? RoadmapCategoryId { get; set; }

        [SqlField("RoadmapCategoryText", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapCategoryText { get; set; }

        [SqlField("RoadmapCategoryIdName", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapCategoryIdName { get; set; }

        [SqlField("RoadmapModuleId", FrameworkTypeEnum.Int)]
        public int? RoadmapModuleId { get; set; }

        [SqlField("RoadmapModuleText", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapModuleText { get; set; }

        [SqlField("RoadmapPriorityId", FrameworkTypeEnum.Int)]
        public int? RoadmapPriorityId { get; set; }

        [SqlField("RoadmapPriorityText", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapPriorityText { get; set; }

        [SqlField("RoadmapPriorityIdName", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapPriorityIdName { get; set; }

        [SqlField("LoginUserId", FrameworkTypeEnum.Int)]
        public int? LoginUserId { get; set; }

        [SqlField("LoginUserText", FrameworkTypeEnum.Nvarcahr)]
        public string LoginUserText { get; set; }

        [SqlField("Date", FrameworkTypeEnum.Date)]
        public DateTime? Date { get; set; }

        [SqlField("RoadmapStateId", FrameworkTypeEnum.Int)]
        public int? RoadmapStateId { get; set; }

        [SqlField("RoadmapStateText", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapStateText { get; set; }

        [SqlField("RoadmapStateIdName", FrameworkTypeEnum.Nvarcahr)]
        public string RoadmapStateIdName { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "RoadmapModule")]
    public class RoadmapModule : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Text", FrameworkTypeEnum.Nvarcahr)]
        public string Text { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "RoadmapModuleBuiltIn")]
    public class RoadmapModuleBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("IdName", FrameworkTypeEnum.Nvarcahr)]
        public string IdName { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Text", FrameworkTypeEnum.Nvarcahr)]
        public string Text { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "RoadmapPriority")]
    public class RoadmapPriority : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Text", FrameworkTypeEnum.Nvarcahr)]
        public string Text { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "RoadmapPriorityBuiltIn")]
    public class RoadmapPriorityBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("IdName", FrameworkTypeEnum.Nvarcahr)]
        public string IdName { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Text", FrameworkTypeEnum.Nvarcahr)]
        public string Text { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "RoadmapState")]
    public class RoadmapState : Row
    {
        [SqlField("Id", true, FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Text", FrameworkTypeEnum.Nvarcahr)]
        public string Text { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }

    [SqlTable("Demo", "RoadmapStateBuiltIn")]
    public class RoadmapStateBuiltIn : Row
    {
        [SqlField("Id", FrameworkTypeEnum.Int)]
        public int Id { get; set; }

        [SqlField("IdName", FrameworkTypeEnum.Nvarcahr)]
        public string IdName { get; set; }

        [SqlField("Name", FrameworkTypeEnum.Nvarcahr)]
        public string Name { get; set; }

        [SqlField("Text", FrameworkTypeEnum.Nvarcahr)]
        public string Text { get; set; }

        [SqlField("Description", FrameworkTypeEnum.Nvarcahr)]
        public string Description { get; set; }

        [SqlField("IsBuiltIn", FrameworkTypeEnum.Bit)]
        public bool IsBuiltIn { get; set; }

        [SqlField("IsExist", FrameworkTypeEnum.Bit)]
        public bool IsExist { get; set; }
    }
}
