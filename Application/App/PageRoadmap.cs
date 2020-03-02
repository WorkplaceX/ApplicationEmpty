﻿namespace Application
{
    using Database.Demo;
    using Framework.DataAccessLayer;
    using Framework.Json;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class PageRoadmap : Page
    {
        public PageRoadmap(ComponentJson owner) : base(owner) 
        {
            new Html(this) { TextHtml = "<h1>Roadmap</h1>" };
            new Html(this) { TextHtml = "This is the development roadmap showing the status of new features and reported bugs." };
        }

        public override async Task InitAsync()
        {
            await new GridRoadmap(this).LoadAsync();
        }
    }

    public class GridRoadmap : Grid<RoadmapDisplay>
    {
        public GridRoadmap(ComponentJson owner) : base(owner) { }

        protected override async Task InsertAsync(RoadmapDisplay rowNew, DatabaseEnum databaseEnum, InsertResult result)
        {
            Roadmap roadmap = new Roadmap();
            Data.RowCopy(rowNew, roadmap);
            roadmap.Name = Guid.NewGuid();
            await Data.InsertAsync(roadmap);
            rowNew.Id = roadmap.Id; // Get new id from db
            rowNew.Name = roadmap.Name;
            rowNew.IsExist = true;
            result.IsHandled = true;
        }

        protected override async Task UpdateAsync(RoadmapDisplay row, RoadmapDisplay rowNew, DatabaseEnum databaseEnum, UpdateResult result)
        {
            Roadmap roadmapNew = new Roadmap();
            Data.RowCopy(rowNew, roadmapNew);
            await Data.UpdateAsync(roadmapNew);
            result.IsHandled = true;
        }

        protected override IQueryable LookupQuery(RoadmapDisplay row, string fieldName, string text)
        {
            if (fieldName == nameof(RoadmapDisplay.RoadmapCategoryText))
            {
                return Data.Query<RoadmapCategory>();
            }
            if (fieldName == nameof(RoadmapDisplay.RoadmapModuleText))
            {
                return Data.Query<RoadmapModule>();
            }
            if (fieldName == nameof(RoadmapDisplay.RoadmapPriorityText))
            {
                return Data.Query<RoadmapPriority>();
            }
            if (fieldName == nameof(RoadmapDisplay.RoadmapStateText))
            {
                return Data.Query<RoadmapState>();
            }
            if (fieldName == nameof(RoadmapDisplay.LoginUserText))
            {
                return Data.Query<LoginUser>();
            }
            return null;
        }

        protected override string LookupRowSelected(Grid gridLookup)
        {
            if (gridLookup.RowSelected is RoadmapCategory roadmapCategory) // Category
            {
                return roadmapCategory.Text;
            }
            if (gridLookup.RowSelected is RoadmapModule roadmapModule) // Module
            {
                return roadmapModule.Text;
            }
            if (gridLookup.RowSelected is RoadmapPriority roadmapPriority) // Priority
            {
                return roadmapPriority.Text;
            }
            if (gridLookup.RowSelected is RoadmapState roadmapState) // State
            {
                return roadmapState.Text;
            }
            if (gridLookup.RowSelected is LoginUser loginUser) // User
            {
                return loginUser.Name;
            }
            return base.LookupRowSelected(gridLookup);
        }

        protected override async Task CellParseAsync(RoadmapDisplay row, string fieldName, string text, CellParseResult result)
        {
            // Category
            if (fieldName == nameof(RoadmapDisplay.RoadmapCategoryText))
            {
                if (text == "")
                {
                    row.RoadmapCategoryId = null;
                    row.RoadmapCategoryText = "";
                }
                else
                {
                    var roadmapCategory = (await Data.SelectAsync(Data.Query<RoadmapCategory>().Where(item => item.Text == text))).FirstOrDefault();
                    if (roadmapCategory == null)
                    {
                        result.ErrorParse = "Category not found!";
                    }
                    else
                    {
                        row.RoadmapCategoryId = roadmapCategory.Id;
                        row.RoadmapCategoryText = roadmapCategory.Text;
                    }
                }
                result.IsHandled = true;
            }

            // Module
            if (fieldName == nameof(RoadmapDisplay.RoadmapModuleText))
            {
                if (text == "")
                {
                    row.RoadmapModuleId = null;
                    row.RoadmapModuleText = "";
                }
                else
                {
                    var roadmapModule = (await Data.SelectAsync(Data.Query<RoadmapModule>().Where(item => item.Text == text))).FirstOrDefault();
                    if (roadmapModule == null)
                    {
                        result.ErrorParse = "Module not found!";
                    }
                    else
                    {
                        row.RoadmapModuleId = roadmapModule.Id;
                        row.RoadmapModuleText = roadmapModule.Text;
                    }
                }
                result.IsHandled = true;
            }

            // Priority
            if (fieldName == nameof(RoadmapDisplay.RoadmapPriorityText))
            {
                if (text == "")
                {
                    row.RoadmapPriorityId = null;
                    row.RoadmapPriorityText = "";
                }
                else
                {
                    var roadmapPriority = (await Data.SelectAsync(Data.Query<RoadmapPriority>().Where(item => item.Text == text))).FirstOrDefault();
                    if (roadmapPriority == null)
                    {
                        result.ErrorParse = "Priority not found!";
                    }
                    else
                    {
                        row.RoadmapPriorityId = roadmapPriority.Id;
                        row.RoadmapPriorityText = roadmapPriority.Text;
                    }
                }
                result.IsHandled = true;
            }

            // State
            if (fieldName == nameof(RoadmapDisplay.RoadmapStateText))
            {
                if (text == "")
                {
                    row.RoadmapStateId = null;
                    row.RoadmapStateText = "";
                }
                else
                {
                    var roadmapState = (await Data.SelectAsync(Data.Query<RoadmapState>().Where(item => item.Text == text))).FirstOrDefault();
                    if (roadmapState == null)
                    {
                        result.ErrorParse = "State not found!";
                    }
                    else
                    {
                        row.RoadmapStateId = roadmapState.Id;
                        row.RoadmapStateText = roadmapState.Text;
                    }
                }
                result.IsHandled = true;
            }

            // User
            if (fieldName == nameof(RoadmapDisplay.LoginUserText))
            {
                if (text == "")
                {
                    row.LoginUserId = null;
                    row.LoginUserText = "";
                }
                else
                {
                    var loginUser = (await Data.SelectAsync(Data.Query<LoginUser>().Where(item => item.Name == text))).FirstOrDefault();
                    if (loginUser == null)
                    {
                        result.ErrorParse = "User name not found!";
                    }
                    else
                    {
                        row.LoginUserId = loginUser.Id;
                        row.LoginUserText = loginUser.Name; // Without database row reload!
                    }
                }
                result.IsHandled = true;
            }
        }
    }
}
