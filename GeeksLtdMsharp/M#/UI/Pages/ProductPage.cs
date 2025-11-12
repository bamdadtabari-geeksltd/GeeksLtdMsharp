using MSharp;

public class ProductPage : RootPage
{
    public ProductPage()
    {
        Roles(AppRole.Admin, AppRole.PM);

        Add<Modules.MainMenu>();

        OnStart(x => x.Go<Product.ProductsPage>().RunServerSide());
    }
}
