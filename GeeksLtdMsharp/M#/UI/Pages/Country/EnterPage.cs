using MSharp;

namespace Country
{
    public class EnterPage : SubPage<CountryPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.CountryForm>();
            
        }
    }
}