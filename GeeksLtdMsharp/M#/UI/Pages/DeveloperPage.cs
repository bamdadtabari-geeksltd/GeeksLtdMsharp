using MSharp;

public class DeveloperPage : RootPage
{
    public DeveloperPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.DevelopersList>();
    }
}