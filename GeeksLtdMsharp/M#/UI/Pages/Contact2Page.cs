using MSharp;
public class Contact2Page : RootPage
{
    public Contact2Page()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.Contacts2List>();
    }
}