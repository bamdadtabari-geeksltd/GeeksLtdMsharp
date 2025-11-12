using MSharp;

namespace ProductCategory
{
    public class ViewPage : SubPage<ProductCategoryPage>
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ProductForm>();
        }
    }

}
