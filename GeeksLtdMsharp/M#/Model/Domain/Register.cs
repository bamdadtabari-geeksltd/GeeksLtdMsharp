using MSharp;

namespace Domain
{
    public class Register : EntityType
    {
        public Register()
        {
            String("First Name").Mandatory();

            String("Last Name").Mandatory();

            Date("Date of birth").Mandatory();

            String("Email").Accepts(TextPattern.EmailAddress).Unique();

            String("Password");

            String("InvitationCode").Calculated();

            UniqueCombination(new[] { "First Name" , "Last Name", "Email"});
        }

    }
}