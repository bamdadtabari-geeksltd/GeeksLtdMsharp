using MSharp;

public class ClientPage : RootPage
{
    public ClientPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.ClientsList>();
    }
}