using MSharp;

namespace Country
{
    public class ViewPage : SubPage<CountryPage>
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.CitiesList>();

            Add<Modules.CustomersList>();
        }
    }
}