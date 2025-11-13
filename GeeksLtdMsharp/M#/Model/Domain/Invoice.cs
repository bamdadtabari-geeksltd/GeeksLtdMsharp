using MSharp;

namespace Domain
{
    public class Invoice : EntityType
    {
        public Invoice()
        {
            Associate<Client>("Client").Mandatory();

            Date("Date");

            Money("Amount").Min(decimal.MinValue);

            String("Description").Max(2500).Lines(5);
        }
    }
}