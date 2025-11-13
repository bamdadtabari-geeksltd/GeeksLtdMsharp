using MSharp;

public class OwnerPage : RootPage
{
    public OwnerPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.OwnersList>();
    }
}