using MSharp;

public class AssetTypePage : RootPage
{
    public AssetTypePage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.AssetTypesList>();
    }
}