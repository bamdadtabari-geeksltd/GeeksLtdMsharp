using MSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class ProductCategoryView : ViewModule<Domain.ProductCategory>
    {
        public ProductCategoryView()
        {
            HeaderText("@item.Name Details").EmptyMarkup("No staff records found");

            Field(x => x.Name);


            Button("Back").IsDefault()
                .Icon(FA.ChevronLeft).OnClick(x => x.ReturnToPreviousPage());

            Button("Delete")
                .ConfirmQuestion("Are you sure you want to delete this Product Category?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.GentleMessage("Deleted successfully.");
                    x.ReturnToPreviousPage();
                });

            Button("Product")
               // item refers the current category
               .RepeatDataSource("await item.Products.GetList()")
               // option refers to the product, check the generated cshtml
               .Text("C#:option.Name")
               .OnClick(x => {
                   x.Go<Product.ProductsPage>().Send("item", "option.ID").SendReturnUrl();
               });

        }
    }
}