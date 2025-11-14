using MSharp;

namespace Country2
{
    public class EnterPage : SubPage<Country2Page>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);
            Add<Modules.Country2Form>();
        }
    }
}