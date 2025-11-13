using MSharp;

namespace Domain
{
    public class EmailTemplate : EntityType
    {
        public EmailTemplate()
        {
            InstanceAccessors("RegistrationConfirmationEmail");
            Implements("Olive.Email.IEmailTemplate");

            DefaultToString = String("Key").Mandatory().Unique();
            String("Subject").Mandatory();
            BigString("Body", 10).Mandatory();
            String("Mandatory placeholders");
        }
    }
}