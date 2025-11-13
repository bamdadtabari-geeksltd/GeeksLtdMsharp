using MSharp;

namespace Domain
{
    public class Reseller : EntityType
    {
        public Reseller()
        {
            String("Name");

            Associate<Country>("Country").Mandatory();
        }
    }
}