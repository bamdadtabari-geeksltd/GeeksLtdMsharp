using MSharp;

namespace AssetType
{
    class EnterPage : SubPage<AssetTypePage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.AssetTypeForm>();
        }
    }
}