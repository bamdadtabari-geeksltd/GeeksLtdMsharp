using MSharp;

namespace Modules
{
    public class CountriesList : ListModule<Domain.Country>
    {
        public CountriesList()
        {
            HeaderText("Countries")
                .ShowHeaderRow();

            LinkColumn("c#:item.Name").OnClick(x => x.Go<Country.ViewPage>()
                .Send("item", "item.ID"));

            Column(x => x.IsEuropean).LabelText("Is European?");

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.PopUp<Country.EnterPage>().Send("item", "item.ID"));

            Button("Add Country").Icon(FA.Plus)
                .OnClick(x => x.PopUp<Country.EnterPage>());
        }
    }
}