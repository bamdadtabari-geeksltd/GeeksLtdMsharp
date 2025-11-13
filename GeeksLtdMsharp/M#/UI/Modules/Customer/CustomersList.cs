using MSharp;

namespace Modules
{
    public class CustomersList : ListModule<Domain.Customer>
    {
        public CustomersList()
        {
            HeaderText("Customers")
                .ShowHeaderRow();

            Column(x => x.Name);
            Column(x => x.Reseller);

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.PopUp<Country.Customer.CustomerEnterPage>()
                    .Send("item", "item.ID")
                    .Send("country", "item.CountryId"));

            Button("Add Customer").Icon(FA.Plus)
                .OnClick(x => x.PopUp<Country.Customer.CustomerEnterPage>()
                    .Send("country", "info.Country.ID"));

            ViewModelProperty("Country", "Country").FromRequestParam("item");

            DataSource("await info.Country.Customers.GetList()");
        }
    }
}