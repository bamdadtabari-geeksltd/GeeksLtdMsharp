using MSharp;
public class CandidatePage : RootPage
{
    public CandidatePage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");
        Add<Modules.CandidatesList>();
    }
}