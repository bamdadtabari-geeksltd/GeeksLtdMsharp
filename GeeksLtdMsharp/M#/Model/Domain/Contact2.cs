using MSharp;

namespace Domain
{
    public class Contact2 : EntityType
    {
        public Contact2()
        {
            Associate<Category>("Category").Mandatory();

            String("Name");

            String("Email");

            String("Telephone");

            String("Address line 1");

            String("Address line 2");

            String("Town");

            String("Postcode");

            String("Comments").Lines(5);

            Date("Date of birth");
        }
    }
}