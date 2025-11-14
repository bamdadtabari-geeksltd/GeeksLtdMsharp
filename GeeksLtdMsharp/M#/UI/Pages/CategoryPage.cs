using MSharp;

public class CategoryPage : RootPage
{
    public CategoryPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.CategoriesList>();
    }
}