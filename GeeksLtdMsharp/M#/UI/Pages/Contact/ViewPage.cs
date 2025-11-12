using MSharp;

namespace Contact
{
    public class ViewPage : SubPage<ContactPage>
    {
        public ViewPage()
        {
            Route("contact/contacts/view/{item}");

            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ContactView>();
            Add<Modules.SharedView>().OnBinding("info.Mode = \"View\";");
        }
    }

}
