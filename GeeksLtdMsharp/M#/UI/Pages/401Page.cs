using MSharp;

public class _401Page : RootPage
{
    public _401Page()
    {
        BrowserTitle("401");

        Add<Modules.Error401>();
    }
}
