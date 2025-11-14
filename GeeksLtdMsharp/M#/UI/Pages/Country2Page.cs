using MSharp;
public class Country2Page : RootPage
{
    public Country2Page()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.Countries2List>();
    }
}