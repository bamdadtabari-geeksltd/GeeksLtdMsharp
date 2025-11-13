using MSharp;

namespace Domain
{
    public class Country : EntityType
    {
        public Country()
        {
            String("Name");

            Bool("Is european").Mandatory();

            InverseAssociate<City>("Cities", "Country");

            InverseAssociate<Customer>("Customers", "Country");

            InverseAssociate<Reseller>("Resellers", "Country");

        }
    }
}