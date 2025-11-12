using MSharp;

public class ProjectPage : RootPage
{
    public ProjectPage()
    {
        Add<Modules.MainMenu>();
        Add<Modules.ProjectsList>();
    }
}