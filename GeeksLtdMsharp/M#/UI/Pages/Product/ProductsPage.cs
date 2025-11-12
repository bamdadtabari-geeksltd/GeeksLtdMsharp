using MSharp;

namespace Product
{
    public class ProductsPage : SubPage<ProductPage>
    {
        public ProductsPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ProductsList>();
        }
    }
}
