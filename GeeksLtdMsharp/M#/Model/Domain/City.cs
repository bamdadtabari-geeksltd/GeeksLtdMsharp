using MSharp;

namespace Domain
{
    public class City : EntityType
    {
        public City()
        {
            String("Name");

            Associate<Country>("Country").Mandatory();
        }
    }
}