using Domain;
using MSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProductCategoryPage : RootPage
{
    public ProductCategoryPage()
    {
        Roles(AppRole.Admin, AppRole.PM);

        Add<Modules.MainMenu>();

        OnStart(x => x.Go<ProductCategory.ProductCategoriesPage>().RunServerSide());
    }
}
