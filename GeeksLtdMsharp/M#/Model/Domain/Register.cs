using MSharp;

namespace Domain
{
    public class Register : EntityType
    {
        public Register()
        {
            String("First name").Mandatory();

            String("Last name").Mandatory();

            Date("Date of birth").Mandatory();

            String("Email").Accepts(TextPattern.EmailAddress).Unique();

            String("Password");

            String("InvitationCode").Calculated();

            UniqueCombination(new[] { "FirstName" , "LastName", "Email"});
        }

    }
}