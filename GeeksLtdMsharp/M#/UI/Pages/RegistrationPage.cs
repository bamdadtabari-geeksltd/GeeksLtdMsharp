using MSharp;

public class RegistrationPage : RootPage
{
    public RegistrationPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.RegistrationForm>();
    }
}