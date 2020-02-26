﻿namespace Application
{
    using Database.Demo;
    using Framework.DataAccessLayer;
    using Framework.Json;
    using System.Linq;
    using System.Threading.Tasks;

    public class PageLoginUser : Page
    {
        public PageLoginUser(ComponentJson owner) : base(owner) { }

        public override async Task InitAsync()
        {
            DivContainer = new Div(this) { CssClass = "container" };

            new Html(DivContainer) { TextHtml = "<h1>User <i class='fas fa-user'></i></h1>" };
            GridLoginUser = new GridLoginUser(DivContainer);

            new Html(DivContainer) { TextHtml = "<h1>User <i class='fas fa-user'></i> to Role <i class='fas fa-hat-cowboy'></i> Mapping</h1>" };
            GridLoginUserRole = new GridLoginUserRole(DivContainer);

            new Html(DivContainer) { TextHtml = "<h1>Permission <i class='fas fa-key'></i></h1>" };
            new Html(DivContainer) { TextHtml = "User has the following permissions:" };
            GridLoginUserPermission = new GridLoginUserPermission(DivContainer);

            await GridLoginUser.LoadAsync();
        }

        public Div DivContainer;

        public GridLoginUser GridLoginUser;

        public GridLoginUserRole GridLoginUserRole;

        public GridLoginUserPermission GridLoginUserPermission;

        protected override void GridCellAnnotation(Grid grid, string fieldName, Row row, GridCellAnnotationResult result)
        {
            if (fieldName == nameof(LoginUser.Password))
            {
                result.IsPassword = true;
            }
        }
    }

    public class GridLoginUser : Grid<LoginUser>
    {
        public GridLoginUser(ComponentJson owner) : base(owner) { }

        protected override async Task RowSelectedAsync()
        {
            var page = this.ComponentOwner<PageLoginUser>();

            // Load detail data grids
            await Task.WhenAll(page.GridLoginUserRole.LoadAsync(), page.GridLoginUserPermission.LoadAsync());
        }
    }

    public class GridLoginUserRole : Grid<LoginUserRoleDisplay>
    {
        public GridLoginUserRole(ComponentJson owner) : base(owner) { }

        protected override IQueryable<LoginUserRoleDisplay> Query()
        {
            var page = this.ComponentOwner<PageLoginUser>();

            return base.Query().Where(item => item.UserId == (page.GridLoginUser.RowSelected).Id);
        }

        protected override async Task<bool> UpdateAsync(LoginUserRoleDisplay row, LoginUserRoleDisplay rowNew, DatabaseEnum databaseEnum)
        {
            var loginUserRole = new LoginUserRole();
            Data.RowCopy(rowNew, loginUserRole);

            await Data.UpsertAsync(loginUserRole, new string[] { nameof(LoginUserRole.UserId), nameof(LoginUserRole.RoleId) });
            return true;
        }
    }

    public class GridLoginUserPermission : Grid<LoginUserPermissionDisplay>
    {
        public GridLoginUserPermission(ComponentJson owner) : base(owner) { }

        protected override IQueryable<LoginUserPermissionDisplay> Query()
        {
            var page = this.ComponentOwner<PageLoginUser>();

            return base.Query().Where(item => item.UserId == (page.GridLoginUser.RowSelected).Id);
        }
    }
}
