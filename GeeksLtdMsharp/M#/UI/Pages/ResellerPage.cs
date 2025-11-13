using MSharp;

public class ResellerPage : RootPage
{
    public ResellerPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Layout(Layouts.AdminDefault);

        Add<Modules.ResellersList>();
    }
}