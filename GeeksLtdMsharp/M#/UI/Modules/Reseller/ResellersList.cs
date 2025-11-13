using MSharp;

namespace Modules
{
    public class ResellersList : ListModule<Domain.Reseller>
    {
        public ResellersList()
        {
            HeaderText("Resellers")
                .ShowHeaderRow();

            Column(x => x.Name);

            Column(x => x.Country);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.PopUp<Reseller.EnterPage>().Send("item", "item.ID"));

            Button("New Reseller").Icon(FA.Plus)
                .OnClick(x => x.PopUp<Reseller.EnterPage>());
        }
    }
}