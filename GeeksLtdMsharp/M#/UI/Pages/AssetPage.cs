using MSharp;

public class AssetPage : RootPage
{
    public AssetPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.AssetsList>();
    }
}