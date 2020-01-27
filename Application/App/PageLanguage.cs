﻿namespace Application
{
    using System.Linq;
    using System.Threading.Tasks;
    using Database.Demo;
    using Framework.DataAccessLayer;
    using Framework.Json;

    public class PageLanguage : Page
    {
        public PageLanguage(ComponentJson owner) : base(owner) { }

        public override async Task InitAsync()
        {
            new Html(this) { TextHtml = "<h1>Language</h1>" };
            await new Grid2(this).LoadAsync();
        }

        protected override IQueryable GridQuery(Grid2 grid)
        {
            return Data.Query<Language>();
        }
    }
}
