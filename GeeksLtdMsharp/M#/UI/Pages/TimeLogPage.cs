using MSharp;

public class TimeLogPage : RootPage
{
    public TimeLogPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.TimeLogsList>();
    }
}