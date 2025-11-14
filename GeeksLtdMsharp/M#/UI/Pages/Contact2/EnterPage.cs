using MSharp;

namespace Contact2
{
    public class EnterPage : SubPage<Contact2Page>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);
            Add<Modules.Contact2Form>();
        }
    }
}