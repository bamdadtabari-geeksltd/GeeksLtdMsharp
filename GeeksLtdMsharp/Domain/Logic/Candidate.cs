using Olive;
using Olive.Email;
using System.Threading.Tasks;

namespace Domain
{
    public partial class Candidate
    {
        public void UpdateStatus(Status status)
        {
            Database.Update(this, x => x.Status = status);
        }

        public static async Task RemindAdminForPendingCandidates()
        {
            var pendingCandidates = await Database.GetList<Candidate>(x => x.Status == Status.Pending);

            if (pendingCandidates.None())
            {
                return;
            }

            //await EmailService.Send(new EmailMessage() { Subject = "Candidate pending reminder", Body = "...", To = "admin@uat.co" });
        }
    }
}