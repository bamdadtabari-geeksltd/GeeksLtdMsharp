using MSharp;

namespace Reseller
{
    public class EnterPage : SubPage<ResellerPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.ResellerForm>();
        }
    }
}