using Olive;
using Olive.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public partial class Register
    {
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
    }
}