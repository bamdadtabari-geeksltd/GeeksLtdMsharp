using MSharp;

namespace Domain
{
    public class Developer : EntityType
    {
        public Developer()
        {
            String("First name");

            String("Last name");

            String("Full name")
                .Calculated()
                .Getter("FirstName + ' ' + LastName");

            String("Latest work")
                .Mandatory()
                .Calculated()
                .Getter("TimeLogs.Max(x => x.Date).Get(x => x?.ToShortDateString()).GetAwaiter().GetResult()");

            ToStringExpression("FullName");

            InverseAssociate<TimeLog>("Time logs", "Developer");

            Decimal("Total work")
                .Mandatory()
                .Calculated()
                .Getter("TimeLogs.GetList().Sum(c => c.Hours).GetAwaiter().GetResult()");
        }
    }
}