using System.Threading.Tasks;
using Domain;
using Olive.Email;
using Olive.Entities.Data;

namespace Domain
{
    public partial class Registration
    {
        public async Task SendConfirmation()
        {
            var template = EmailTemplate.RegistrationConfirmationEmail;

            var placeHolderValues = new
            {
                FirstName = this.FirstName,
                LastName = this.LastName
            };

            var emailMessage = new EmailMessage
            {
                Subject = template.MergeSubject(placeHolderValues),
                To = this.Email,
                Body = template.MergeBody(placeHolderValues)
            };

            await Database.Save(emailMessage);
        }
    }
}