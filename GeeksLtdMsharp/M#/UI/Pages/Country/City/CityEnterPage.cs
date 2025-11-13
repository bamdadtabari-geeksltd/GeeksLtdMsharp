using MSharp;

namespace Country.City
{
    public class CityEnterPage : SubPage<ViewPage>
    {
        public CityEnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.CityForm>();
        }
    }
}