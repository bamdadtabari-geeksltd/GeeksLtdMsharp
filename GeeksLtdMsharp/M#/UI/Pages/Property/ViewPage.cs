using MSharp;

namespace Property
{
    public class ViewPage : SubPage<PropertyPage>
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.PropertyView>();
        }
    }

}
