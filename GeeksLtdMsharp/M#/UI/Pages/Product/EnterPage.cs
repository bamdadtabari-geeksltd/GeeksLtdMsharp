using MSharp;

namespace Product
{
    public class EnterPage : SubPage<ProductPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.ProductForm>();
        }
    }

}
