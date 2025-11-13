using MSharp;

namespace Modules
{
    public class CitiesList : ListModule<Domain.City>
    {
        public CitiesList()
        {
            HeaderText("Cities of @info.Country.Name");

            Column(x => x.Name).LabelText("City name");

            ButtonColumn("Edit").Icon(FA.Edit)
                .OnClick(x => x.PopUp<Country.City.CityEnterPage>()
                    .Send("item", "item.ID")
                    .Send("country", "item.CountryId"));

            Button("New City").Icon(FA.Plus)
                .OnClick(x => x.PopUp<Country.City.CityEnterPage>()
                    .Send("country", "info.Country.ID"));

            ViewModelProperty("Country", "Country").FromRequestParam("item");

            DataSource("await info.Country.Cities.GetList()");
        }
    }
}