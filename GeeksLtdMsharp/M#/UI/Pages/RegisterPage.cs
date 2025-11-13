using MSharp;

public class RegisterPage : RootPage
{
    public RegisterPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");

        Add<Modules.RegisterForm>();
    }
}