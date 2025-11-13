using MSharp;

namespace Domain
{
    public class Registration : EntityType
    {
        public Registration()
        {
            String("First name");

            String("Last name");

            String("Email");

            Bool("IsSubscribed").Mandatory();
        }
    }
}