using MSharp;

namespace Owner
{
    class EnterPage : SubPage<OwnerPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.OwnerForm>();
        }
    }
}