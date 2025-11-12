
using MSharp;

public class PropertyPage : RootPage
{
    public PropertyPage()
    {
        Roles(AppRole.Admin);

        Add<Modules.MainMenu>();

        OnStart(x => x.Go<Property.PropertiesPage>().RunServerSide());
    }
}

