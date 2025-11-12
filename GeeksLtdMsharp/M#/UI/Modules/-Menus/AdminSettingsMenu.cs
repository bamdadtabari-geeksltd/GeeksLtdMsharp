using MSharp;
using Domain;

namespace Modules
{
    public class AdminSettingsMenu : MenuModule
    {
        public AdminSettingsMenu()
        {
            SubItemBehaviour(MenuSubItemBehaviour.ExpandCollapse);
            WrapInForm(false);
            AjaxRedirect();
            IsViewComponent();
            RootCssClass("sidebar-menu");
            UlCssClass("nav flex-column");
            Using("Olive.Security");

            Item("Product Categories").Icon(FA.Cat)
                .OnClick(x => x.Go<ProductCategoryPage>());

            Item("Products")
                .OnClick(x => x.Go<ProductPage>());

            Item("Contacts")
                .OnClick(x => x.Go<ContactPage>());

            Item("Administrators")
                .OnClick(x => x.Go<Admin.Settings.AdministratorsPage>());

            Item("General Settings")
                .OnClick(x => x.Go<Admin.Settings.GeneralPage>());

            Item("Product Summery")
                .OnClick(x => x.Go<SummaryPage>());

            Item("Property")
                .OnClick(x => x.Go<PropertyPage>());

            Item("Projects").Icon(FA.Cog)
                .OnClick(x => x.Go<ProjectPage>());

            Item("ProjectTasks").Icon(FA.Cog)
                .OnClick(x => x.Go<ProjectTaskPage>());

        }
    }
}