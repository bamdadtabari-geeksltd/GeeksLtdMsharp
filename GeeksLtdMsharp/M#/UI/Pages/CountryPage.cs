using MSharp;

public class CountryPage : RootPage
{
    public CountryPage()
    {
        Layout(Layouts.AdminDefault);

        Add<Modules.CountriesList>();
        
    }
}