using MSharp;

namespace Asset
{
    class EnterPage : SubPage<AssetPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.AssetForm>();
        }
    }
}