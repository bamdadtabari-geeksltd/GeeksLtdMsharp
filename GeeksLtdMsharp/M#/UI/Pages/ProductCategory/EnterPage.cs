using MSharp;

namespace ProductCategory
{
    public class EnterPage : SubPage<ProductCategoryPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.ProductCategoryForm>();
        }
    }

}
