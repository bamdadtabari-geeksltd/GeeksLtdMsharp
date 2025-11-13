using MSharp;

namespace Asset
{
    class ViewPage : SubPage<AssetPage>
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefault);

            Add<Modules.AssetView>();
        }
    }
}