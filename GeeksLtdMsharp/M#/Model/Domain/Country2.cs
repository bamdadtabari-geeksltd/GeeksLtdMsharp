using MSharp;

namespace Domain
{
    public class Country2 : EntityType
    {
        public Country2()
        {
            String("Name").Mandatory();

            String("Code").Mandatory();
        }
    }
}