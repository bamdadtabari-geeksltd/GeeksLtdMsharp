using MSharp;

namespace Domain
{
    public class EmailMessage : EntityType
    {
        public EmailMessage()
        {
            SoftDelete().Implements("Olive.Email.IEmailMessage");

            BigString("Body").Lines(5).Mandatory();
            String("From address");
            String("From name");
            String("Reply to address");
            String("Reply to name");
            String("Subject");
            String("To");
            BigString("Attachments");
            String("Bcc").Max(2000);
            String("Cc").Max(2000);
            String("VCalendarView");
            Int("Retries").Mandatory();
            DateTime("Sendable date").Default("c#:LocalTime.Now").Mandatory();
            Bool("Html").Mandatory();
        }
    }
}