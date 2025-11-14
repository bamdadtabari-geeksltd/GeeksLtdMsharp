using MSharp;

namespace Modules
{
    public class Contacts2List : ListModule<Domain.Contact2>
    {
        public Contacts2List()
        {
            HeaderText("Contacts");

            Column(x => x.Name);

            Column(x => x.Category).VisibleIf("info.Category == null");

            Column(x => x.Email);

            Column(x => x.Telephone);

            ViewModelProperty("Category", "Category").FromRequestParam("category");

            DataSource("info.Category == null ? await  Database.GetList<Contact2>() : await info.Category.Contacts2.GetList()");

            ButtonColumn("Edit").Icon(FA.Edit)
                .HeaderText("Edit").GridColumnCssClass("actions")
                .OnClick(x => x.Go<Contact2.EnterPage>().Send("item", "item.ID"));

            ButtonColumn("Delete").Icon(FA.Remove)
                .HeaderText("Delete").GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Contact?")
                .CssClass("btn-danger")
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Contact").Icon(FA.Plus)
                .OnClick(x => x.Go<Contact2.EnterPage>().Send("category", "info.Category?.ID"));
        }
    }
}