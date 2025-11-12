using MSharp;

namespace Domain
{
    class Address : EntityType
    {
        public Address()
        {
            String("Address Line 1").Mandatory();
            String("Address Line 2").Mandatory();
            String("Postal Code").Mandatory();
            String("Town").Mandatory();

            Associate<Property>("Property").Mandatory().Unique().CascadeDelete();

        }
    }
}