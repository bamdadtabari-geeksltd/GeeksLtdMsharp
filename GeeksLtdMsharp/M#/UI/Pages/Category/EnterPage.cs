using MSharp;

namespace Category
{
    public class EnterPage : SubPage<CategoryPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);
            Add<Modules.CategoryForm>();
        }
    }
}