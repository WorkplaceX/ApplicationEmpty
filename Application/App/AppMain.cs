﻿namespace Application
{
    using Framework.DataAccessLayer;
    using Framework.Json;
    using System.Threading.Tasks;

    public class AppMain : AppJson
    {
        public AppMain() : this(null) { }

        public AppMain(ComponentJson owner) : base(owner) { }

        protected override async Task InitAsync()
        {
            if (this.IsSessionExpired)
            {
                this.BootstrapAlert(sessionExpired, "Session expired!", BootstrapAlertEnum.Warning);
            }

            bool isDemoPage = false;

            if (isDemoPage == false)
            {
                await this.ComponentPageShowAsync<PageAirplane>();
                await this.ComponentPageShowAsync<PageCountry>();
            }
            else
            {
                await this.ComponentPageShowAsync<PageDemo>();
            }

            this.ComponentCreate<Button>().TextHtml = "Click";

            new Html(this).TextHtml = "<p>Build 2019-12-21 10:10</p>";
        }

        private const string sessionExpired = "SessionExpired";

        protected override Task<bool> GridUpdateAsync(Grid grid, Row row, Row rowNew, DatabaseEnum databaseEnum)
        {
            return base.GridUpdateAsync(grid, row, rowNew, databaseEnum);
        }

        protected override Task ProcessAsync()
        {
            if (this.ComponentGet(sessionExpired) != null && this.IsSessionExpired == false)
            {
                this.ComponentGet(sessionExpired).ComponentRemove();
            }
            return base.ProcessAsync();
        }
    }

    public class AppX : AppJson
    {
        public AppX() : this(null) { }

        public AppX(ComponentJson owner) : base(owner) { }

        protected override Task InitAsync()
        {
            this.ComponentCreate<Html>().TextHtml = "Hello ApplicationX";

            return base.InitAsync();
        }
    }
}
