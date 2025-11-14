using MSharp;

namespace Domain
{
    public class Fan : EntityType
    {
        public Fan()
        {
            Associate<Player>("Player").Mandatory().DatabaseIndex();

            String("Name").Mandatory();

            String("Email").Accepts(TextPattern.EmailAddress).Mandatory();

            Date("Start date").Mandatory();

            Date("Date of birth").Mandatory(false);

            String("Support comments").Lines(5);

            Bool("Is registration completed").Mandatory();
        }
    }
}