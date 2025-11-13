using MSharp;

public class Project2Page : RootPage
{
    public Project2Page()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.Projects2List>();
    }
}