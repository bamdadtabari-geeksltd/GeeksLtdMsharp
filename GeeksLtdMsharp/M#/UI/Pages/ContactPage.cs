using MSharp;

public class ContactPage : RootPage
{
    public ContactPage()
    {
        Set(PageSettings.LeftMenu, "AdminSettingsMenu");

        OnStart(x => x.Go<Contact.ContactsPage>().RunServerSide());
    }
}
