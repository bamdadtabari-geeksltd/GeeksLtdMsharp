using MSharp;

namespace Domain
{
    public class Project2 : EntityType
    {
        public Project2()
        {
            String("Name");

            InverseAssociate<TimeLog>("TimeLogs", "Project2");

            Decimal("Total work hours")
                .Mandatory()
                .Calculated()
                .Getter("TimeLogs.GetList().Sum(x => x.Hours).GetAwaiter().GetResult()");
        }
    }
}