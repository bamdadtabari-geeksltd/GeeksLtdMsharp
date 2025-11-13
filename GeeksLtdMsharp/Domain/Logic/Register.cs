using Olive;
using Olive.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Domain
{
    public partial class Register
    {
        // Generate an invitation code for new instances.
        public Register()
        {
            // If new (no ID assigned yet), generate a code.
            if (ID == Guid.Empty)
                InvitationCode = GenerateInvitationCode();
        }

        public override Task Validate()
        {
            // Guard: ensure DateOfBirth is set
            var dob = this.DateOfBirth;
            var today = LocalTime.Now.Date;

            if (dob == default || dob == DateTime.MinValue)
                throw new ValidationException("Date of birth is required.");

            // Accurate age calculation (accounts for month/day)
            var age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            if (age < 18)
                throw new ValidationException("User must be at least 18 years old to register.");

            // Basic email sanity check and reject disposable/common free domains explicitly
            var email = (Email ?? string.Empty).Trim();
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                throw new ValidationException("A valid email address is required.");

            var domain = email.Split('@').Last().ToLowerInvariant();
            if (domain.EndsWith("gmail.com") || domain.EndsWith("yahoo.com"))
                throw new ValidationException("Gmail and Yahoo emails are not accepted.");

            return base.Validate();
        }

        private static string GenerateInvitationCode(int length = 10)
        {
            const string alphabet = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789"; // avoid ambiguous chars
            var sb = new StringBuilder(length);
            var bytes = new byte[length];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            for (int i = 0; i < length; i++)
            {
                sb.Append(alphabet[bytes[i] % alphabet.Length]);
            }
            return sb.ToString();
        }
    }
}