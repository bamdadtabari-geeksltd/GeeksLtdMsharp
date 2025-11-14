using MSharp;

namespace Domain
{
    public class Company : EntityType
    {
        public Company()
        {
            String("Name").Mandatory();

            Date("Registration date").Mandatory();

            Decimal("Market share").IsPercentage().Scale(2).Min(0).Max(100).Mandatory();

            Int("Number of employees").Mandatory();

            Associate<Country2>("Country2").Mandatory();
        }
    }
}