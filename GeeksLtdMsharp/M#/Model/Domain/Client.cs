using MSharp;

namespace Domain
{
    public class Client : EntityType
    {
        public Client()
        {
            String("Company").Mandatory();

            InverseAssociate<Invoice>("Invoices", "Client");
        }
    }
}