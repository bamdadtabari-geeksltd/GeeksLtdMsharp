using MSharp;

namespace Product
{
    public class ViewPage : SubPage<ProductPage>
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ProductView>();
        }
    }

}
