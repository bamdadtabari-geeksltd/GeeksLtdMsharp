using MSharp;

namespace Domain
{
    public class Candidate : EntityType
    {
        public Candidate()
        {
            String("First name").Mandatory();

            String("Last name").Mandatory();

            String("Email").Accepts(TextPattern.EmailAddress);

            String("Telephone").Accepts(TextPattern.UKMobilePhoneNumber);

            String("Convering letter").Lines(5);

            Date("Date Added").Mandatory().Default("C#:LocalTime.Now");

            Associate<Status>("Status").Default("Pending");
        }
    }
}