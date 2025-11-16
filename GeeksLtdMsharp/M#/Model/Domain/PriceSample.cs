using MSharp;

namespace Domain
{
    public class PriceSample: EntityType
    {
        public PriceSample()
        {
            Decimal("Price").Mandatory();
            DateTime("Sample Date").Mandatory();
        }
    }
}
