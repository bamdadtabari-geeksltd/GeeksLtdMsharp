using MSharp;

public class ResellerPage : RootPage
{
    public ResellerPage()
    {
        Layout(Layouts.AdminDefault);

        Add<Modules.ResellersList>();
    }
}