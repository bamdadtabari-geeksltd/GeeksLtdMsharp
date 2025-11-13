using MSharp;

namespace Country.Customer
{
    public class CustomerEnterPage : SubPage<ViewPage>
    {
        public CustomerEnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.CustomerForm>();
        }
    }
}