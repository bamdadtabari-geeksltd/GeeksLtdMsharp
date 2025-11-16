using MSharp;

namespace Domain
{
    public class Status : EntityType
    {
        public Status()
        {
            GenerateParseMethod();

            IsEnumReference();

            InstanceAccessors(new[] { "Pending", "Interviewed", "Rejected", "Offered" });

            String("Name");
        }
    }
}