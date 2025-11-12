using MSharp;

namespace ProductCategory
{
    public class ProductCategoriesPage : SubPage<ProductCategoryPage>
    {
        public ProductCategoriesPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ProductCategoriesList>();
        }
    }
}
