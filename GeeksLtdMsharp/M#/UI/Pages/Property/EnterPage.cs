using MSharp;

namespace Property
{
    public class EnterPage : SubPage<PropertyPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.PropertyForm>();
        }
    }

}
