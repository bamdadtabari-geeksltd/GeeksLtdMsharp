using MSharp;
public class CompanyPage : RootPage
{
    public CompanyPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.CompaniesList>();
    }
}