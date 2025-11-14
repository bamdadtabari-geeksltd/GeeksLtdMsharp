using MSharp;

public class TennisPlayerPage : RootPage
{
    public TennisPlayerPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.PlayersList>();
    }
}