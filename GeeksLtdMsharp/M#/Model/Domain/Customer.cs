using MSharp;

namespace Domain
{
    public class Customer : EntityType
    {
        public Customer()
        {
            String("Name");

            Associate<Reseller>("Reseller").Mandatory();

            Associate<Country>("Country").Mandatory();
        }
    }
}