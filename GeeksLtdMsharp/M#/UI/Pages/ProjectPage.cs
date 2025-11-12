using MSharp;

public class ProjectPage : RootPage
{
    public ProjectPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.ProjectsList>();
    }
}