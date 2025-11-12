using MSharp;

public class ProjectTaskPage : RootPage
{
    public ProjectTaskPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");

        Add<Modules.ProjectTaskList>();
    }
}