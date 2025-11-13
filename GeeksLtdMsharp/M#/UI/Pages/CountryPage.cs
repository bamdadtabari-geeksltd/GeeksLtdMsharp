using MSharp;

public class CountryPage : RootPage
{
    public CountryPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Layout(Layouts.AdminDefault);

        Add<Modules.CountriesList>();
        
    }
}