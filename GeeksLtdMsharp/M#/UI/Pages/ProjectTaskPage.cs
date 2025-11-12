using MSharp;

public class ProjectTaskPage : RootPage
{
    public ProjectTaskPage()
    {
        Add<Modules.MainMenu>();

        Add<Modules.ProjectTaskList>();
    }
}