using MSharp;

public class SummaryPage : RootPage
{
    public SummaryPage()
    {
        Add<Modules.MainMenu>();

        Add<Modules.ProductCategoriesList>();
        Add<Modules.ProductsList>();
    }
}