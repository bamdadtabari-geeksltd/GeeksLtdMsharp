using MSharp;

namespace Company
{
    public class EnterPage : SubPage<CompanyPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);
            Add<Modules.CompanyForm>();
        }
    }
}