using MSharp;

namespace Modules
{
    public class OwnersList : ListModule<Domain.Owner>
    {
        public OwnersList()
        {
            HeaderText("Owners");

            Column(x => x.FirstName);
            Column(x => x.LastName);

            ButtonColumn("Edit").Icon(FA.Edit)
                .HeaderText("Edit").GridColumnCssClass("actions")
                .OnClick(x => x.Go<Owner.EnterPage>()
                    .Send("item", "item.ID")
                    .SendReturnUrl());

            ButtonColumn("Delete").Icon(FA.Remove)
                .HeaderText("Delete").GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Owner?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.Reload();
                });

            Button("Add Owner").Icon(FA.Plus)
                .OnClick(x => x.Go<Owner.EnterPage>()
                    .SendReturnUrl());
        }
    }
}