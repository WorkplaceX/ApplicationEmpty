﻿namespace Application
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Database.Demo;
    using Framework.Application;
    using Framework.Dal;
    using Framework.Json;
    using Framework.Session;

    public class PageCountry : Page
    {
        public PageCountry() { }

        public PageCountry(ComponentJson owner) : base(owner) { }

        protected override async Task InitAsync()
        {
            this.ComponentCreate<Html>().TextHtml = "<h1>Country</h1>";
            await this.ComponentCreate<Grid>().LoadAsync();
        }

        protected override IQueryable GridQuery(Grid grid)
        {
            return UtilDal.Query<CountryDisplayCache>();
        }

        private void GridCellAnnotationBool(string fieldName, Expression<Func<bool?>> property, GridCellAnnotationResult result)
        {
            UtilApplication.PropertyValueGet(property, out var propertyFieldName, out var value);

            if (fieldName == propertyFieldName)
            {
                if (value == true)
                {
                    result.Html = "<i class='fas fa-check'></i>";
                }
                if (value == false)
                {
                    result.Html = "<i class='far fa-square'></i>";
                }
            }
        }

        protected override void GridCellAnnotation(Grid grid, string fieldName, GridRowEnum gridRowEnum, Row row, GridCellAnnotationResult result)
        {
            var countryDisplay = row as CountryDisplayCache;
            if (fieldName == nameof(CountryDisplayCache.Country) && countryDisplay?.ASFlagIcon != null)
            {
                result.HtmlLeft = string.Format("<span class='flag-icon {0}'></span>", countryDisplay.ASFlagIcon);
            }

            if (fieldName == nameof(CountryDisplayCache.WikipediaCountryUrl) && countryDisplay?.WikipediaCountryUrl != null)
            {
                result.Html = string.Format("<a href='{0}' target='_blank'>{1}", countryDisplay?.WikipediaCountryUrl, "Wikipedia");
            }

            GridCellAnnotationBool(fieldName, () => (row as CountryDisplayCache).IsWikipedia, result);
            GridCellAnnotationBool(fieldName, () => (row as CountryDisplayCache).IsOpenFlightsAirport, result);
            GridCellAnnotationBool(fieldName, () => (row as CountryDisplayCache).IsOpenFlightsAirline, result);
            GridCellAnnotationBool(fieldName, () => (row as CountryDisplayCache).IsFlagIconCss, result);
        }
    }
}
