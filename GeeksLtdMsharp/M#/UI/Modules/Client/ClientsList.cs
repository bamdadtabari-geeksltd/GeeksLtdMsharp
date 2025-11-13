using MSharp;

namespace Modules
{
    public class ClientsList : ListModule<Domain.Client>
    {
        public ClientsList()
        {
            HeaderText("Clients")
                .UseDatabasePaging(false)
                .Sortable()
                .PageSize(5)
                .ShowFooterRow()
                .ShowHeaderRow()
                .PagerPosition(PagerAt.Bottom);

            Column(x => x.Company);

            Column(x => x.Invoices).IsSortable(false);

            ButtonColumn("Add Invoice").Style(ButtonStyle.Link)
                .OnClick(x => x.Go<Client.AddInvoicePage>()
                    .SendReturnUrl()
                    .Send("client", "item.ID"));

            ButtonColumn("Edit").Icon(FA.Edit)
                .HeaderText("Edit").GridColumnCssClass("actions")
                .OnClick(x => x.Go<Client.EnterPage>()
                    .SendReturnUrl()
                    .Send("item", "item.ID"));

            ButtonColumn("Delete").Icon(FA.Remove)
                .HeaderText("Delete").GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Client?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("Add client").Icon(FA.Plus)
                .OnClick(x => x.Go<Client.EnterPage>()
                    .SendReturnUrl());
        }
    }
}