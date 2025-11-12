using MSharp;

namespace Modules
{
    public class PropertiesList : ListModule<Domain.Property>
    {
        public PropertiesList()
        {
            HeaderText("Properties")
                .UseDatabasePaging(false)
                .Sortable()
                .PageSize(10)
                .ShowFooterRow()
                .ShowHeaderRow()
                .PagerPosition(PagerAt.Bottom);

            IndexColumn();
            UpdateWithPost();

            Search(GeneralSearch.AllFields).Label("Find");

            SearchButton("Search").OnClick(x => x.Reload());


            ButtonColumn("c#:item.Name")
                .Style(ButtonStyle.Link)
                .HeaderText("Name")
                .OnClick(x => x.Go<Property.ViewPage>().SendReturnUrl()
                .Send("item", "item.ID"));

            Column(x => x.Price);

            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                .OnClick(x => x.PopUp<Property.EnterPage>()
                    .Send("item", "item.ID").SendReturnUrl(false));

            ButtonColumn("Delete")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Property?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Do(CommonAction.ShowPleaseWait);
                    x.RefreshPage();
                });

            Button("New Property")
                .Icon(FA.Plus)
                .OnClick(x => x.PopUp<Property.EnterPage>().SendReturnUrl(false).ModalWidth("1000").ModalHeight("1000"));
        }
    }
}
