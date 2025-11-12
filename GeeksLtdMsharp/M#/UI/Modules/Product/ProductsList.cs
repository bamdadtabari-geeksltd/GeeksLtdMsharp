using MSharp;

namespace Modules
{
    public class ProductsList : ListModule<Domain.Product>
    {
        public ProductsList()
        {
            Prefix("pl");

            HeaderText("Products")
               .UseDatabasePaging(false)
               .Sortable()
               .PageSize(10)
               .ShowFooterRow()
               .ShowHeaderRow()
               .PagerPosition(PagerAt.Bottom);

            // just for test
            ViewModelProperty("ProductCategory", "ProductCategoryData").FromRequestParam("item");

            Search(x => x.ProductCategory)
                .AsRadioButtons(Arrange.Horizontal)
                .DataSource("#ALL#")
                .Label("Classification")
                .ReloadOnChange();
            Search(x => x.Name)
                .NoLabel()
                .WatermarkText("Enter Name");

            PageSize(5);
            PageSizeSelector(PagerAt.Top);
            PagerPosition(PagerAt.TopAndBottom);

            //Search(GeneralSearch.AllFields).Label("Find");

            SearchButton("Search").OnClick(x => x.Reload());

            ButtonColumn("c#:item.Name")
                .Style(ButtonStyle.Link)
                .HeaderText("Name")
                .OnClick(x => x.Go<Product.ViewPage>()
                .Send("item", "item.ID")).DisplayMode(DisplayMode.Always);

            ImageColumn("Photo")
                // Change column header
                .HeaderText("Image")
                // The image address to display in the table
                .ImageUrl("c#:item.Photo.Url()")
                .Tooltip("Download")
                // on click workflow
                .OnClick(x => x.Go("c#:item.Photo.Url()")).DisplayMode(DisplayMode.Selectable);

            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                .OnClick(x => x.PopUp<Product.EnterPage>()
                .Send("item", "item.ID").SendReturnUrl(false));

            ButtonColumn("Delete")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Product?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                    x.Do(CommonAction.ShowPleaseWait);
                });

            Button("New Product")
                .Icon(FA.Plus)
                .OnClick(x => x.PopUp<Product.EnterPage>().SendReturnUrl(false));


            Button("This button exports to CSV")
                .OnClick(x => x.Export(ExportFormat.Csv)
                    .Set(CommonActionParameter.ExportToCsv_FileName, "My Contacts"));

            Button("This button exports to Excel")
                .OnClick(x => x.Export(ExportFormat.Excel)
                    .Set(CommonActionParameter.ExportToExcel_FileName, "My Contacts"));

        }
    }
}
