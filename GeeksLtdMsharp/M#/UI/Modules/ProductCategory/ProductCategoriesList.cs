using Domain;
using MSharp;

namespace Modules
{
    public class ProductCategoriesList : ListModule<Domain.ProductCategory>
    {
        public ProductCategoriesList()
        {
            Prefix("pcl");

             HeaderText("Product Category")
               .UseDatabasePaging(false)
               .Sortable()
               .PageSize(10)
               .ShowFooterRow()
               .ShowHeaderRow()
               .PagerPosition(PagerAt.Bottom);
            
            IndexColumn();
            UpdateWithPost();

            //SelectCheckbox(true);
            //SelectCheckboxColumnIndex(3);

            Search(GeneralSearch.AllFields).Label("Find");

            SearchButton("Search").OnClick(x => x.Reload());

            //ButtonColumn("c#:item.Name")
            //    .Style(ButtonStyle.Link)
            //    .HeaderText("Name")
            //    .OnClick(x => x.Go<ProductCategory.ViewPage>().SendReturnUrl()
            //    .Send("item", "item.ID"));

            Column(x => x.Name).AsTextbox().HeaderTemplate("<strong> this the name </strong>");

            ButtonColumn("Save")
           .NoHeaderText()
           .GridColumnCssClass("actions")
           .Icon(FA.Save)
           .OnClick(x => {
               x.CSharp("item.UpdateName(info.Items.First(x=> x.Item.ID == item.ID).Name);");
               x.GentleMessage("Product Category Name Updated !!");
               x.RefreshPage();
           });

            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                .OnClick(x => x.PopUp<ProductCategory.EnterPage>()
                .Send("item", "item.ID").SendReturnUrl(false));

            ButtonColumn("Delete")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Product Category?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Do(CommonAction.ShowPleaseWait);
                    x.RefreshPage();
                });

            Button("New Product Category")
                .Icon(FA.Plus)
                .OnClick(x => x.PopUp<ProductCategory.EnterPage>().SendReturnUrl(false).ModalWidth("1000").ModalHeight("1000"));
        }
    }
}
