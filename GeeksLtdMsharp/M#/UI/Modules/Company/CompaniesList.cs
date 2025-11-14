using MSharp;

namespace Modules
{
    public class CompaniesList : ListModule<Domain.Company>
    {
        public CompaniesList()
        {
            HeaderText("Companies");

            Search(c => c.Country2).DisplayExpression("item.Code");

            SearchButton("Search").OnClick(x => x.Reload());

            Column(x => x.Name).LabelText("Company name");

            Column(x => x.RegistrationDate)
                .DisplayExpression("c#:string.Format(\"{0:yyyy-MMM-dd}\", item.RegistrationDate).ToUpper()");

            Column(x => x.MarketShare);

            Column(x => x.NumberOfEmployees).DisplayFormat("{0:n0}");

            Column(x => x.Country2).HeaderTemplate("Country");

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.Go<Company.EnterPage>()
                    .Send("item", "item.ID")
                    .SendReturnUrl());

            Button("New Company").Icon(FA.Plus)
                .OnClick(x => x.Go<Company.EnterPage>().SendReturnUrl());
        }
    }
}