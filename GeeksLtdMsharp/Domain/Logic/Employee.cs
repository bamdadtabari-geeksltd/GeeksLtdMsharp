using System.Text;

namespace Domain
{
    public partial class Employee
    {
        public string GetWarnings()
        {
            var result = new StringBuilder();

            if (IDCard.IsEmpty())
            {
                result.Append("Missing ID Card.");
            }

            if (string.IsNullOrEmpty(Email))
            {
                result.Append("<br/>Missing email address");
            }

            return result.ToString();
        }

    }
}